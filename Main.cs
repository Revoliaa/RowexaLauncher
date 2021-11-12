using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Threading;
using CmlLib.Core.Version;
using System.Management;
using CmlLib.Utils;
using System.Diagnostics;
using System.Net.Http;
using MojangAPI;
using MojangAPI.Model;
using System.Net;

namespace RowexaLauncher
{
    public partial class Main : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static string version;
        public static string latestversion;
        public static double fres;
        public static string user;
        public static string email;
        public static string password;

        public static int fixedres1;
        public static int fixedres2;
        public static int maximumRam;

        public static int defaultnavpanelheight;
        public static int defaultnavpaneltop;
        public static int defaultnavpanelleft;
        public static int defaultnavpanel2height;
        public static int defaultnavpanel2top;
        public static int defaultnavpanel2left;

        private Changelogs changelogs;

        MSession session;
        MinecraftPath myPath = new MinecraftPath("./RowexaLauncher");

        public Main()
        {
            InitializeComponent();
            KeyPreview = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            defaultnavpanelheight = panel_nav.Height;
            defaultnavpaneltop = panel_nav.Top;
            defaultnavpanelleft = panel_nav.Left;
            defaultnavpanel2height = panel_nav2.Height;
            defaultnavpanel2top = panel_nav2.Top;
            defaultnavpanel2left = panel_nav2.Left;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            panel_news.Visible = false;
            panel_settings.Visible = false;
            panel_welcome.Visible = true;
            panel_news.Enabled = false;
            panel_settings.Enabled = false;
            panel_welcome.Enabled = true;

            label_username.Visible = false;
            btn_logout.Visible = false;

            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            double res;

            foreach (ManagementObject result in results)
            {
                res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                fres = Math.Round((res / (1024 * 1024)), 2);
            }

            changelogs = await Changelogs.GetChangelogs();
            var launcher = new CMLauncher(myPath);
            var versions = launcher.GetAllVersions();
            var latest = versions.LatestReleaseVersion.Name;

            var body = await changelogs.GetChangelogHtml(latest);
            browser_updates.DocumentText = body;
            path();
            GetSettings();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (checkBox_offline.Checked)
            {
                Regex regexItem = new Regex("^(([A-z0-9_]){3,16})$");

                if (regexItem.IsMatch(textBox_username.Text))
                {
                    user = textBox_username.Text;
                    panel_login.Visible = false;
                    panel_main.Visible = true;
                    label_username.Text = user;
                    label_username.Visible = true;
                    btn_logout.Visible = true;

                    var launcher = new CMLauncher(myPath);
                    MVersionCollection versions = await launcher.GetAllVersionsAsync();
                    latestversion = versions.LatestReleaseVersion.Name;
                    comboBox_version.SelectedItem = latestversion;

                    panel_news.Enabled = true;
                    panel_news.Visible = true;
                    panel_welcome.Enabled = false;
                    panel_welcome.Visible = false;
                }
                else
                {
                    label_loginerror1.Text = "Kullanıcı adı şu şartları sağlamalıdır:";
                    label_loginerror2.Text = "● A-Z a-z 0-9 _ karakterleri içerebilir.";
                    label_loginerror3.Text = "● 3-16 karakter arasında olmalı.";
                }
            }
            else
            {
                string rgx = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                Regex regexItem = new Regex(rgx);

                if (regexItem.IsMatch(textBox_username.Text))
                {
                    email = textBox_username.Text;
                    password = textBox_password.Text;
                    var login = new MLogin();
                    var response = login.Authenticate(email, password);
                    if (!response.IsSuccess)
                    {
                        label_loginerror1.Text = "E-Posta veya şifre yanlış";
                        label_loginerror2.Text = "Lütfen tekrar dene.";
                        label_loginerror3.Text = "";
                    }
                    else
                    {
                        HttpClient httpClient = new HttpClient();
                        Mojang mojang = new Mojang(httpClient);

                        session = response.Session;
                        PlayerProfile profile = await mojang.GetProfileUsingUUID(session.UUID);
                        panel_login.Visible = false;
                        panel_main.Visible = true;
                        label_username.Text = profile.Name;
                        label_username.Visible = true;
                        btn_logout.Visible = true;

                        var launcher = new CMLauncher(myPath);
                        MVersionCollection versions = await launcher.GetAllVersionsAsync();
                        latestversion = versions.LatestReleaseVersion.Name;
                        comboBox_version.SelectedItem = latestversion;

                        panel_news.Enabled = true;
                        panel_news.Visible = true;
                        panel_welcome.Enabled = false;
                        panel_welcome.Visible = false;
                    }
                }
                else
                {
                    label_loginerror1.Text = "Geçerli bir e-posta gir lütfen.";
                    label_loginerror2.Text = "";
                    label_loginerror3.Text = "";
                }
            }
        }

        public void GetSettings()
        {
            textBox_ram.Text = Properties.Settings.Default.Ram.ToString();
            textBox_res1.Text = Properties.Settings.Default.Resolution1.ToString();
            textBox_res2.Text = Properties.Settings.Default.Resolution2.ToString();
            if (Properties.Settings.Default.Snapshot == false)
            {
                checkBox_snapshot.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox_snapshot.CheckState = CheckState.Checked;
            }

            if (Properties.Settings.Default.Beta == false)
            {
                checkBox_beta.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox_beta.CheckState = CheckState.Checked;
            }

            if (Properties.Settings.Default.Alpha == false)
            {
                checkBox_alpha.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox_alpha.CheckState = CheckState.Checked;
            }

            if (Properties.Settings.Default.FullScreen == false)
            {
                checkBox_fullScreen.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox_fullScreen.CheckState = CheckState.Checked;
            }
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Ram = Int32.Parse(textBox_ram.Text);
            Properties.Settings.Default.Resolution1 = Int32.Parse(textBox_res1.Text);
            Properties.Settings.Default.Resolution2 = Int32.Parse(textBox_res2.Text);

            if (checkBox_snapshot.Checked)
            {
                Properties.Settings.Default.Snapshot = true;
            }
            else
            {
                Properties.Settings.Default.Snapshot = false;
            }

            if (checkBox_beta.Checked)
            {
                Properties.Settings.Default.Beta = true;
            }
            else
            {
                Properties.Settings.Default.Beta = false;
            }

            if (checkBox_alpha.Checked)
            {
                Properties.Settings.Default.Alpha = true;
            }
            else
            {
                Properties.Settings.Default.Alpha = false;
            }

            if (checkBox_fullScreen.Checked)
            {
                Properties.Settings.Default.FullScreen = true;
            }
            else
            {
                Properties.Settings.Default.FullScreen = false;
            }

            Properties.Settings.Default.Save();
        }

        private void path()
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;
            var launcher = new CMLauncher(myPath);

            var versions = launcher.GetAllVersions();
            foreach (var ver in versions)
            {
                if (ver.Type.Equals("release"))
                {
                    comboBox_version.Items.Add(ver.Name);
                }
                if (ver.Type.Equals("local"))
                {
                    comboBox_version.Items.Add(ver.Name);
                }
            }
        }

        private void launch()
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;
            var launcher = new CMLauncher(myPath);

            bool isFullscreen;

            if (Properties.Settings.Default.FullScreen == true)
            {
                isFullscreen = true;
                fixedres1 = 0;
                fixedres2 = 0;
            }
            else
            {
                isFullscreen = false;
                fixedres1 = Properties.Settings.Default.Resolution1;
                fixedres2 = Properties.Settings.Default.Resolution2;
            }

            if (checkBox_offline.Checked)
            {
                session = MSession.GetOfflineSession(user);
            }

            var launchOption = new MLaunchOption
            {
                Session = session,
                MaximumRamMb = Int32.Parse(textBox_ram.Text),
                ScreenWidth = fixedres1,
                ScreenHeight = fixedres2,
                FullScreen = isFullscreen
            };

            version = comboBox_version.SelectedItem.ToString();
            var process = launcher.CreateProcess(version, launchOption);

            process.Start();
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_news.Height;
            panel_nav.Top = btn_news.Top;
            panel_nav.Left = btn_news.Left;
            btn_news.BackColor = Color.FromArgb(46, 51, 73);

            panel_news.Visible = true;
            panel_settings.Visible = false;
            panel_news.Enabled = true;
            panel_settings.Enabled = false;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_settings.Height;
            panel_nav.Top = btn_settings.Top;
            panel_nav.Left = btn_settings.Left;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);

            panel_news.Visible = false;
            panel_settings.Visible = true;
            panel_news.Enabled = false;
            panel_settings.Enabled = true;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            panel_nav2.Height = btn_play.Height;
            panel_nav2.Top = btn_play.Top;
            panel_nav2.Left = btn_play.Left;
            btn_play.BackColor = Color.FromArgb(46, 51, 73);

            btn_play.Enabled = false;
            btn_logout.Enabled = false;
            btn_play.Text = "Yükleniyor";
            Thread thread = new Thread(() => launch());
            thread.IsBackground = true;
            thread.Start();
        }

        private void btn_news_Leave(object sender, EventArgs e)
        {
            btn_news.BackColor = Color.FromArgb(44, 44, 46);
        }

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(44, 44, 46);
        }

        private void btn_play_Leave(object sender, EventArgs e)
        {
            btn_play.BackColor = Color.FromArgb(44, 44, 46);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_logo.Visible = true;
            label_username.Visible = false;
            btn_logout.Visible = false;
            panel_news.Visible = false; 
            panel_settings.Visible = false;
            panel_welcome.Visible = true;

            if (!checkBox_offline.Checked)
            {
                textBox_password.Text = "";
            }

            panel_nav.Height = defaultnavpanelheight;
            panel_nav.Top = defaultnavpaneltop;
            panel_nav.Left = defaultnavpanelleft;

            panel_nav2.Height = defaultnavpanel2height;
            panel_nav2.Top = defaultnavpanel2top;
            panel_nav2.Left = defaultnavpanel2left;

            label_loginerror1.Text = "";
            label_loginerror2.Text = "";
            label_loginerror3.Text = "";
        }

        private void browser_updates_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            browser_updates.Document.BackColor = Color.FromArgb(44,44,46);
            browser_updates.Document.ForeColor = Color.White;
        }

        private void pictureBox_discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/inviteID");
        }

        private void checkBox_snapshot_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_snapshot.Checked)
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                var launcher = new CMLauncher(myPath);

                var versions = launcher.GetAllVersions();
                foreach (var ver in versions)
                {
                    if (ver.Type.Equals("snapshot"))
                    {
                        comboBox_version.Items.Add(ver.Name);
                    }
                }
            }
            else
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                var launcher = new CMLauncher(myPath);

                var versions = launcher.GetAllVersions();
                foreach (var ver in versions)
                {
                    if (ver.Type.Equals("snapshot"))
                    {
                        comboBox_version.Items.Remove(ver.Name);
                    }
                }
            }
        }

        private void checkBox_beta_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_beta.Checked)
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                var launcher = new CMLauncher(myPath);

                var versions = launcher.GetAllVersions();
                foreach (var ver in versions)
                {
                    if (ver.Type.Equals("old_beta"))
                    {
                        comboBox_version.Items.Add(ver.Name);
                    }
                }
            }
            else
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                var launcher = new CMLauncher(myPath);

                var versions = launcher.GetAllVersions();
                foreach (var ver in versions)
                {
                    if (ver.Type.Equals("old_beta"))
                    {
                        comboBox_version.Items.Remove(ver.Name);
                    }
                }
            }
        }

        private void checkBox_alpha_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_alpha.Checked)
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                var launcher = new CMLauncher(myPath);

                var versions = launcher.GetAllVersions();
                foreach (var ver in versions)
                {
                    if (ver.Type.Equals("old_alpha"))
                    {
                        comboBox_version.Items.Add(ver.Name);
                    }
                }
            }
            else
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                var launcher = new CMLauncher(myPath);

                var versions = launcher.GetAllVersions();
                foreach (var ver in versions)
                {
                    if (ver.Type.Equals("old_alpha"))
                    {
                        comboBox_version.Items.Remove(ver.Name);
                    }
                }
            }
        }

        private void checkBox_offline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_offline.Checked)
            {
                textBox_password.Visible = false;
                textBox_password.Enabled = false;
                textBox_username.PlaceholderText = "Kullanıcı Adı";
            }
            else
            {
                textBox_password.Visible = true;
                textBox_password.Enabled = true;
                textBox_username.PlaceholderText = "E-Posta";
                textBox_password.Text = "";
            }
        }

        private void btn_applySettings_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox_ram.Text) > Convert.ToInt32(fres) * 1024)
            {
                label_saveText.ForeColor = Color.Red;
                label_saveText.Text = "Bu kadar Ram'e sahip değilsin.";
            }
            else if (Int32.Parse(textBox_ram.Text) < 1024)
            {
                label_saveText.ForeColor = Color.Red;
                label_saveText.Text = "En az 1024 MB Ram verebilirsin.";
            }
            else
            {
                label_saveText.ForeColor = Color.Green;
                label_saveText.Text = "Başarıyla kaydedildi.";
                SaveSettings();
            }
        }

        private void textBox_res1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_res2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }
    }
}
