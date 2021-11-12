
namespace RowexaLauncher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dragControl__Main = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label_launcherName = new System.Windows.Forms.Label();
            this.panel_logo = new ReaLTaiizor.Controls.Panel();
            this.pictureBox_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_main = new ReaLTaiizor.Controls.Panel();
            this.panel_login = new Guna.UI2.WinForms.Guna2Panel();
            this.label_loginerror3 = new System.Windows.Forms.Label();
            this.label_loginerror2 = new System.Windows.Forms.Label();
            this.label_loginerror1 = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBox_offline = new Guna.UI2.WinForms.Guna2CheckBox();
            this.comboBox_version = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel_nav2 = new System.Windows.Forms.Panel();
            this.btn_play = new System.Windows.Forms.Button();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_news = new System.Windows.Forms.Button();
            this.panel_news = new ReaLTaiizor.Controls.Panel();
            this.browser_updates = new System.Windows.Forms.WebBrowser();
            this.panel_settings = new ReaLTaiizor.Controls.Panel();
            this.label_saveText = new System.Windows.Forms.Label();
            this.checkBox_alpha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox_beta = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox_snapshot = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_applySettings = new Guna.UI2.WinForms.Guna2Button();
            this.label_ramMB = new System.Windows.Forms.Label();
            this.textBox_ram = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_ram = new System.Windows.Forms.Label();
            this.checkBox_fullScreen = new Guna.UI2.WinForms.Guna2CheckBox();
            this.textBox_res2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_resX = new System.Windows.Forms.Label();
            this.textBox_res1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel_welcome = new ReaLTaiizor.Controls.Panel();
            this.panel_discord = new ReaLTaiizor.Controls.Panel();
            this.label_discord = new System.Windows.Forms.Label();
            this.pictureBox_discord = new System.Windows.Forms.PictureBox();
            this.elipse_discord = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.panel_news.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.panel_welcome.SuspendLayout();
            this.panel_discord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_discord)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControl__Main
            // 
            this.dragControl__Main.TargetControl = this;
            // 
            // label_launcherName
            // 
            this.label_launcherName.AutoSize = true;
            this.label_launcherName.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_launcherName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_launcherName.Location = new System.Drawing.Point(35, 105);
            this.label_launcherName.Name = "label_launcherName";
            this.label_launcherName.Size = new System.Drawing.Size(215, 32);
            this.label_launcherName.TabIndex = 3;
            this.label_launcherName.Text = "Rowexa Launcher";
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.label_launcherName);
            this.panel_logo.Controls.Add(this.pictureBox_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.EdgeColor = System.Drawing.Color.Transparent;
            this.panel_logo.Location = new System.Drawing.Point(5, 5);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Padding = new System.Windows.Forms.Padding(5);
            this.panel_logo.Size = new System.Drawing.Size(280, 165);
            this.panel_logo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_logo.TabIndex = 4;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = global::RowexaLauncher.Properties.Resources.logo;
            this.pictureBox_logo.ImageRotate = 0F;
            this.pictureBox_logo.Location = new System.Drawing.Point(86, 15);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.ShadowDecoration.Parent = this.pictureBox_logo;
            this.pictureBox_logo.Size = new System.Drawing.Size(114, 96);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 2;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.UseTransparentBackground = true;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel_main.Controls.Add(this.panel_login);
            this.panel_main.Controls.Add(this.comboBox_version);
            this.panel_main.Controls.Add(this.panel_nav2);
            this.panel_main.Controls.Add(this.btn_play);
            this.panel_main.Controls.Add(this.panel_nav);
            this.panel_main.Controls.Add(this.btn_settings);
            this.panel_main.Controls.Add(this.btn_news);
            this.panel_main.Controls.Add(this.panel_logo);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.EdgeColor = System.Drawing.Color.Transparent;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(5);
            this.panel_main.Size = new System.Drawing.Size(290, 720);
            this.panel_main.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_main.TabIndex = 5;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel_login.Controls.Add(this.label_loginerror3);
            this.panel_login.Controls.Add(this.label_loginerror2);
            this.panel_login.Controls.Add(this.label_loginerror1);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.checkBox_offline);
            this.panel_login.Location = new System.Drawing.Point(-1, 170);
            this.panel_login.Name = "panel_login";
            this.panel_login.ShadowDecoration.Parent = this.panel_login;
            this.panel_login.Size = new System.Drawing.Size(291, 550);
            this.panel_login.TabIndex = 8;
            // 
            // label_loginerror3
            // 
            this.label_loginerror3.AutoSize = true;
            this.label_loginerror3.ForeColor = System.Drawing.Color.Red;
            this.label_loginerror3.Location = new System.Drawing.Point(27, 375);
            this.label_loginerror3.Name = "label_loginerror3";
            this.label_loginerror3.Size = new System.Drawing.Size(0, 17);
            this.label_loginerror3.TabIndex = 10;
            // 
            // label_loginerror2
            // 
            this.label_loginerror2.AutoSize = true;
            this.label_loginerror2.ForeColor = System.Drawing.Color.Red;
            this.label_loginerror2.Location = new System.Drawing.Point(27, 341);
            this.label_loginerror2.Name = "label_loginerror2";
            this.label_loginerror2.Size = new System.Drawing.Size(0, 17);
            this.label_loginerror2.TabIndex = 9;
            // 
            // label_loginerror1
            // 
            this.label_loginerror1.AutoSize = true;
            this.label_loginerror1.ForeColor = System.Drawing.Color.Red;
            this.label_loginerror1.Location = new System.Drawing.Point(27, 303);
            this.label_loginerror1.Name = "label_loginerror1";
            this.label_loginerror1.Size = new System.Drawing.Size(0, 17);
            this.label_loginerror1.TabIndex = 8;
            // 
            // btn_login
            // 
            this.btn_login.Animated = true;
            this.btn_login.AutoRoundedCorners = true;
            this.btn_login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 16;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.DisabledState.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.DimGray;
            this.btn_login.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(64, 225);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(160, 35);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.BorderColor = System.Drawing.Color.Transparent;
            this.textBox_username.BorderRadius = 15;
            this.textBox_username.BorderThickness = 0;
            this.textBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_username.DefaultText = "";
            this.textBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_username.DisabledState.Parent = this.textBox_username;
            this.textBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_username.FillColor = System.Drawing.Color.DimGray;
            this.textBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_username.FocusedState.Parent = this.textBox_username;
            this.textBox_username.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_username.ForeColor = System.Drawing.Color.White;
            this.textBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_username.HoverState.Parent = this.textBox_username;
            this.textBox_username.IconLeft = global::RowexaLauncher.Properties.Resources.user;
            this.textBox_username.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBox_username.Location = new System.Drawing.Point(33, 34);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.PasswordChar = '\0';
            this.textBox_username.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.textBox_username.PlaceholderText = "E-Posta";
            this.textBox_username.SelectedText = "";
            this.textBox_username.ShadowDecoration.Parent = this.textBox_username;
            this.textBox_username.Size = new System.Drawing.Size(225, 35);
            this.textBox_username.TabIndex = 6;
            this.textBox_username.TextOffset = new System.Drawing.Point(1, 0);
            // 
            // textBox_password
            // 
            this.textBox_password.BorderColor = System.Drawing.Color.Transparent;
            this.textBox_password.BorderRadius = 15;
            this.textBox_password.BorderThickness = 0;
            this.textBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_password.DefaultText = "";
            this.textBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_password.DisabledState.Parent = this.textBox_password;
            this.textBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_password.FillColor = System.Drawing.Color.DimGray;
            this.textBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_password.FocusedState.Parent = this.textBox_password;
            this.textBox_password.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_password.HoverState.Parent = this.textBox_password;
            this.textBox_password.IconLeft = global::RowexaLauncher.Properties.Resources.key;
            this.textBox_password.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBox_password.Location = new System.Drawing.Point(33, 109);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.textBox_password.PlaceholderText = "Şifre";
            this.textBox_password.SelectedText = "";
            this.textBox_password.ShadowDecoration.Parent = this.textBox_password;
            this.textBox_password.Size = new System.Drawing.Size(225, 35);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TextOffset = new System.Drawing.Point(1, 0);
            // 
            // checkBox_offline
            // 
            this.checkBox_offline.AutoSize = true;
            this.checkBox_offline.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_offline.CheckedState.BorderRadius = 3;
            this.checkBox_offline.CheckedState.BorderThickness = 0;
            this.checkBox_offline.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_offline.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBox_offline.ForeColor = System.Drawing.Color.White;
            this.checkBox_offline.Location = new System.Drawing.Point(188, 156);
            this.checkBox_offline.Name = "checkBox_offline";
            this.checkBox_offline.Size = new System.Drawing.Size(70, 21);
            this.checkBox_offline.TabIndex = 3;
            this.checkBox_offline.Text = "Offline";
            this.checkBox_offline.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_offline.UncheckedState.BorderRadius = 3;
            this.checkBox_offline.UncheckedState.BorderThickness = 0;
            this.checkBox_offline.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBox_offline.CheckedChanged += new System.EventHandler(this.checkBox_offline_CheckedChanged);
            // 
            // comboBox_version
            // 
            this.comboBox_version.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_version.BorderThickness = 0;
            this.comboBox_version.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_version.DropDownHeight = 210;
            this.comboBox_version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_version.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_version.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_version.FocusedState.Parent = this.comboBox_version;
            this.comboBox_version.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox_version.ForeColor = System.Drawing.Color.Black;
            this.comboBox_version.HoverState.Parent = this.comboBox_version;
            this.comboBox_version.IntegralHeight = false;
            this.comboBox_version.ItemHeight = 30;
            this.comboBox_version.ItemsAppearance.Parent = this.comboBox_version;
            this.comboBox_version.Location = new System.Drawing.Point(46, 326);
            this.comboBox_version.Name = "comboBox_version";
            this.comboBox_version.ShadowDecoration.Parent = this.comboBox_version;
            this.comboBox_version.Size = new System.Drawing.Size(209, 36);
            this.comboBox_version.TabIndex = 14;
            // 
            // panel_nav2
            // 
            this.panel_nav2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_nav2.Location = new System.Drawing.Point(0, 603);
            this.panel_nav2.Name = "panel_nav2";
            this.panel_nav2.Size = new System.Drawing.Size(3, 75);
            this.panel_nav2.TabIndex = 7;
            // 
            // btn_play
            // 
            this.btn_play.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_play.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_play.Image = global::RowexaLauncher.Properties.Resources.play;
            this.btn_play.Location = new System.Drawing.Point(5, 640);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(280, 75);
            this.btn_play.TabIndex = 7;
            this.btn_play.Text = "Oyna";
            this.btn_play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.Leave += new System.EventHandler(this.btn_play_Leave);
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_nav.Location = new System.Drawing.Point(0, 195);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(3, 100);
            this.panel_nav.TabIndex = 6;
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_settings.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_settings.Image = global::RowexaLauncher.Properties.Resources.settings;
            this.btn_settings.Location = new System.Drawing.Point(5, 245);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(280, 75);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.Text = "Ayarlar";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_Leave);
            // 
            // btn_news
            // 
            this.btn_news.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_news.FlatAppearance.BorderSize = 0;
            this.btn_news.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_news.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_news.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_news.Image = global::RowexaLauncher.Properties.Resources.home;
            this.btn_news.Location = new System.Drawing.Point(5, 170);
            this.btn_news.Name = "btn_news";
            this.btn_news.Size = new System.Drawing.Size(280, 75);
            this.btn_news.TabIndex = 5;
            this.btn_news.Text = "Yenilikler";
            this.btn_news.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_news.UseVisualStyleBackColor = true;
            this.btn_news.Click += new System.EventHandler(this.btn_news_Click);
            this.btn_news.Leave += new System.EventHandler(this.btn_news_Leave);
            // 
            // panel_news
            // 
            this.panel_news.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel_news.Controls.Add(this.browser_updates);
            this.panel_news.EdgeColor = System.Drawing.Color.Transparent;
            this.panel_news.Location = new System.Drawing.Point(325, 75);
            this.panel_news.Name = "panel_news";
            this.panel_news.Padding = new System.Windows.Forms.Padding(5);
            this.panel_news.Size = new System.Drawing.Size(920, 620);
            this.panel_news.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_news.TabIndex = 5;
            // 
            // browser_updates
            // 
            this.browser_updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_updates.Location = new System.Drawing.Point(5, 5);
            this.browser_updates.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser_updates.Name = "browser_updates";
            this.browser_updates.Size = new System.Drawing.Size(910, 610);
            this.browser_updates.TabIndex = 0;
            this.browser_updates.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_updates_DocumentCompleted);
            // 
            // panel_settings
            // 
            this.panel_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel_settings.Controls.Add(this.label_saveText);
            this.panel_settings.Controls.Add(this.checkBox_alpha);
            this.panel_settings.Controls.Add(this.checkBox_beta);
            this.panel_settings.Controls.Add(this.checkBox_snapshot);
            this.panel_settings.Controls.Add(this.btn_applySettings);
            this.panel_settings.Controls.Add(this.label_ramMB);
            this.panel_settings.Controls.Add(this.textBox_ram);
            this.panel_settings.Controls.Add(this.label_ram);
            this.panel_settings.Controls.Add(this.checkBox_fullScreen);
            this.panel_settings.Controls.Add(this.textBox_res2);
            this.panel_settings.Controls.Add(this.label_resX);
            this.panel_settings.Controls.Add(this.textBox_res1);
            this.panel_settings.Controls.Add(this.label_res);
            this.panel_settings.EdgeColor = System.Drawing.Color.Transparent;
            this.panel_settings.Location = new System.Drawing.Point(325, 75);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Padding = new System.Windows.Forms.Padding(5);
            this.panel_settings.Size = new System.Drawing.Size(920, 620);
            this.panel_settings.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_settings.TabIndex = 6;
            // 
            // label_saveText
            // 
            this.label_saveText.AutoSize = true;
            this.label_saveText.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_saveText.ForeColor = System.Drawing.Color.White;
            this.label_saveText.Location = new System.Drawing.Point(167, 304);
            this.label_saveText.Name = "label_saveText";
            this.label_saveText.Size = new System.Drawing.Size(0, 17);
            this.label_saveText.TabIndex = 22;
            // 
            // checkBox_alpha
            // 
            this.checkBox_alpha.AutoSize = true;
            this.checkBox_alpha.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_alpha.CheckedState.BorderRadius = 3;
            this.checkBox_alpha.CheckedState.BorderThickness = 0;
            this.checkBox_alpha.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_alpha.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_alpha.ForeColor = System.Drawing.Color.White;
            this.checkBox_alpha.Location = new System.Drawing.Point(247, 221);
            this.checkBox_alpha.Name = "checkBox_alpha";
            this.checkBox_alpha.Size = new System.Drawing.Size(69, 24);
            this.checkBox_alpha.TabIndex = 21;
            this.checkBox_alpha.Text = "Alpha";
            this.checkBox_alpha.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_alpha.UncheckedState.BorderRadius = 3;
            this.checkBox_alpha.UncheckedState.BorderThickness = 0;
            this.checkBox_alpha.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBox_alpha.CheckStateChanged += new System.EventHandler(this.checkBox_alpha_CheckStateChanged);
            // 
            // checkBox_beta
            // 
            this.checkBox_beta.AutoSize = true;
            this.checkBox_beta.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_beta.CheckedState.BorderRadius = 3;
            this.checkBox_beta.CheckedState.BorderThickness = 0;
            this.checkBox_beta.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_beta.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_beta.ForeColor = System.Drawing.Color.White;
            this.checkBox_beta.Location = new System.Drawing.Point(152, 221);
            this.checkBox_beta.Name = "checkBox_beta";
            this.checkBox_beta.Size = new System.Drawing.Size(60, 24);
            this.checkBox_beta.TabIndex = 20;
            this.checkBox_beta.Text = "Beta";
            this.checkBox_beta.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_beta.UncheckedState.BorderRadius = 3;
            this.checkBox_beta.UncheckedState.BorderThickness = 0;
            this.checkBox_beta.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBox_beta.CheckStateChanged += new System.EventHandler(this.checkBox_beta_CheckStateChanged);
            // 
            // checkBox_snapshot
            // 
            this.checkBox_snapshot.AutoSize = true;
            this.checkBox_snapshot.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_snapshot.CheckedState.BorderRadius = 3;
            this.checkBox_snapshot.CheckedState.BorderThickness = 0;
            this.checkBox_snapshot.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_snapshot.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_snapshot.ForeColor = System.Drawing.Color.White;
            this.checkBox_snapshot.Location = new System.Drawing.Point(35, 221);
            this.checkBox_snapshot.Name = "checkBox_snapshot";
            this.checkBox_snapshot.Size = new System.Drawing.Size(93, 24);
            this.checkBox_snapshot.TabIndex = 20;
            this.checkBox_snapshot.Text = "Snapshot";
            this.checkBox_snapshot.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_snapshot.UncheckedState.BorderRadius = 3;
            this.checkBox_snapshot.UncheckedState.BorderThickness = 0;
            this.checkBox_snapshot.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBox_snapshot.CheckStateChanged += new System.EventHandler(this.checkBox_snapshot_CheckStateChanged);
            // 
            // btn_applySettings
            // 
            this.btn_applySettings.Animated = true;
            this.btn_applySettings.AutoRoundedCorners = true;
            this.btn_applySettings.BorderColor = System.Drawing.Color.Transparent;
            this.btn_applySettings.BorderRadius = 13;
            this.btn_applySettings.CheckedState.Parent = this.btn_applySettings;
            this.btn_applySettings.CustomImages.Parent = this.btn_applySettings;
            this.btn_applySettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_applySettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_applySettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_applySettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_applySettings.DisabledState.Parent = this.btn_applySettings;
            this.btn_applySettings.FillColor = System.Drawing.Color.DimGray;
            this.btn_applySettings.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_applySettings.ForeColor = System.Drawing.Color.White;
            this.btn_applySettings.HoverState.Parent = this.btn_applySettings;
            this.btn_applySettings.Location = new System.Drawing.Point(30, 297);
            this.btn_applySettings.Name = "btn_applySettings";
            this.btn_applySettings.ShadowDecoration.Parent = this.btn_applySettings;
            this.btn_applySettings.Size = new System.Drawing.Size(103, 28);
            this.btn_applySettings.TabIndex = 13;
            this.btn_applySettings.Text = "Kaydet";
            this.btn_applySettings.Click += new System.EventHandler(this.btn_applySettings_Click);
            // 
            // label_ramMB
            // 
            this.label_ramMB.AutoSize = true;
            this.label_ramMB.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ramMB.ForeColor = System.Drawing.Color.White;
            this.label_ramMB.Location = new System.Drawing.Point(243, 146);
            this.label_ramMB.Name = "label_ramMB";
            this.label_ramMB.Size = new System.Drawing.Size(35, 21);
            this.label_ramMB.TabIndex = 18;
            this.label_ramMB.Text = "MB";
            // 
            // textBox_ram
            // 
            this.textBox_ram.Animated = true;
            this.textBox_ram.BorderColor = System.Drawing.Color.Transparent;
            this.textBox_ram.BorderThickness = 0;
            this.textBox_ram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_ram.DefaultText = "";
            this.textBox_ram.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_ram.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_ram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_ram.DisabledState.Parent = this.textBox_ram;
            this.textBox_ram.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_ram.FillColor = System.Drawing.Color.DimGray;
            this.textBox_ram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_ram.FocusedState.Parent = this.textBox_ram;
            this.textBox_ram.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_ram.ForeColor = System.Drawing.Color.White;
            this.textBox_ram.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_ram.HoverState.Parent = this.textBox_ram;
            this.textBox_ram.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBox_ram.Location = new System.Drawing.Point(152, 146);
            this.textBox_ram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ram.Name = "textBox_ram";
            this.textBox_ram.PasswordChar = '\0';
            this.textBox_ram.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.textBox_ram.PlaceholderText = "";
            this.textBox_ram.SelectedText = "";
            this.textBox_ram.ShadowDecoration.Parent = this.textBox_ram;
            this.textBox_ram.Size = new System.Drawing.Size(84, 24);
            this.textBox_ram.TabIndex = 17;
            this.textBox_ram.TextOffset = new System.Drawing.Point(1, 0);
            this.textBox_ram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ram_KeyPress);
            // 
            // label_ram
            // 
            this.label_ram.AutoSize = true;
            this.label_ram.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ram.ForeColor = System.Drawing.Color.White;
            this.label_ram.Location = new System.Drawing.Point(31, 149);
            this.label_ram.Name = "label_ram";
            this.label_ram.Size = new System.Drawing.Size(48, 21);
            this.label_ram.TabIndex = 16;
            this.label_ram.Text = "Ram:";
            // 
            // checkBox_fullScreen
            // 
            this.checkBox_fullScreen.AutoSize = true;
            this.checkBox_fullScreen.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_fullScreen.CheckedState.BorderRadius = 3;
            this.checkBox_fullScreen.CheckedState.BorderThickness = 0;
            this.checkBox_fullScreen.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_fullScreen.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_fullScreen.ForeColor = System.Drawing.Color.White;
            this.checkBox_fullScreen.Location = new System.Drawing.Point(35, 95);
            this.checkBox_fullScreen.Name = "checkBox_fullScreen";
            this.checkBox_fullScreen.Size = new System.Drawing.Size(102, 24);
            this.checkBox_fullScreen.TabIndex = 11;
            this.checkBox_fullScreen.Text = "Tam Ekran";
            this.checkBox_fullScreen.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBox_fullScreen.UncheckedState.BorderRadius = 3;
            this.checkBox_fullScreen.UncheckedState.BorderThickness = 0;
            this.checkBox_fullScreen.UncheckedState.FillColor = System.Drawing.Color.Gray;
            // 
            // textBox_res2
            // 
            this.textBox_res2.Animated = true;
            this.textBox_res2.BorderColor = System.Drawing.Color.Transparent;
            this.textBox_res2.BorderThickness = 0;
            this.textBox_res2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_res2.DefaultText = "";
            this.textBox_res2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_res2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_res2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_res2.DisabledState.Parent = this.textBox_res2;
            this.textBox_res2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_res2.FillColor = System.Drawing.Color.DimGray;
            this.textBox_res2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_res2.FocusedState.Parent = this.textBox_res2;
            this.textBox_res2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_res2.ForeColor = System.Drawing.Color.White;
            this.textBox_res2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_res2.HoverState.Parent = this.textBox_res2;
            this.textBox_res2.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBox_res2.Location = new System.Drawing.Point(270, 34);
            this.textBox_res2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_res2.Name = "textBox_res2";
            this.textBox_res2.PasswordChar = '\0';
            this.textBox_res2.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.textBox_res2.PlaceholderText = "";
            this.textBox_res2.SelectedText = "";
            this.textBox_res2.ShadowDecoration.Parent = this.textBox_res2;
            this.textBox_res2.Size = new System.Drawing.Size(84, 24);
            this.textBox_res2.TabIndex = 15;
            this.textBox_res2.TextOffset = new System.Drawing.Point(1, 0);
            this.textBox_res2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_res2_KeyPress);
            // 
            // label_resX
            // 
            this.label_resX.AutoSize = true;
            this.label_resX.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_resX.ForeColor = System.Drawing.Color.White;
            this.label_resX.Location = new System.Drawing.Point(243, 35);
            this.label_resX.Name = "label_resX";
            this.label_resX.Size = new System.Drawing.Size(20, 21);
            this.label_resX.TabIndex = 14;
            this.label_resX.Text = "X";
            // 
            // textBox_res1
            // 
            this.textBox_res1.Animated = true;
            this.textBox_res1.BorderColor = System.Drawing.Color.Transparent;
            this.textBox_res1.BorderThickness = 0;
            this.textBox_res1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_res1.DefaultText = "";
            this.textBox_res1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_res1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_res1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_res1.DisabledState.Parent = this.textBox_res1;
            this.textBox_res1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_res1.FillColor = System.Drawing.Color.DimGray;
            this.textBox_res1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_res1.FocusedState.Parent = this.textBox_res1;
            this.textBox_res1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_res1.ForeColor = System.Drawing.Color.White;
            this.textBox_res1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_res1.HoverState.Parent = this.textBox_res1;
            this.textBox_res1.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBox_res1.Location = new System.Drawing.Point(152, 34);
            this.textBox_res1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_res1.Name = "textBox_res1";
            this.textBox_res1.PasswordChar = '\0';
            this.textBox_res1.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.textBox_res1.PlaceholderText = "";
            this.textBox_res1.SelectedText = "";
            this.textBox_res1.ShadowDecoration.Parent = this.textBox_res1;
            this.textBox_res1.Size = new System.Drawing.Size(84, 24);
            this.textBox_res1.TabIndex = 11;
            this.textBox_res1.TextOffset = new System.Drawing.Point(1, 0);
            this.textBox_res1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_res1_KeyPress);
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_res.ForeColor = System.Drawing.Color.White;
            this.label_res.Location = new System.Drawing.Point(31, 35);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(102, 21);
            this.label_res.TabIndex = 13;
            this.label_res.Text = "Çözünürlük:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(325, 24);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(85, 21);
            this.label_username.TabIndex = 11;
            this.label_username.Text = "username";
            // 
            // btn_logout
            // 
            this.btn_logout.Animated = true;
            this.btn_logout.AutoRoundedCorners = true;
            this.btn_logout.BorderColor = System.Drawing.Color.Transparent;
            this.btn_logout.BorderRadius = 9;
            this.btn_logout.CheckedState.Parent = this.btn_logout;
            this.btn_logout.CustomImages.Parent = this.btn_logout;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.DisabledState.Parent = this.btn_logout;
            this.btn_logout.FillColor = System.Drawing.Color.DimGray;
            this.btn_logout.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.HoverState.Parent = this.btn_logout;
            this.btn_logout.Location = new System.Drawing.Point(325, 48);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Parent = this.btn_logout;
            this.btn_logout.Size = new System.Drawing.Size(83, 21);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Çıkış";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel_welcome
            // 
            this.panel_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel_welcome.Controls.Add(this.panel_discord);
            this.panel_welcome.EdgeColor = System.Drawing.Color.Transparent;
            this.panel_welcome.Location = new System.Drawing.Point(325, 75);
            this.panel_welcome.Name = "panel_welcome";
            this.panel_welcome.Padding = new System.Windows.Forms.Padding(5);
            this.panel_welcome.Size = new System.Drawing.Size(915, 620);
            this.panel_welcome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_welcome.TabIndex = 6;
            // 
            // panel_discord
            // 
            this.panel_discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.panel_discord.Controls.Add(this.label_discord);
            this.panel_discord.Controls.Add(this.pictureBox_discord);
            this.panel_discord.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel_discord.Location = new System.Drawing.Point(30, 30);
            this.panel_discord.Name = "panel_discord";
            this.panel_discord.Padding = new System.Windows.Forms.Padding(5);
            this.panel_discord.Size = new System.Drawing.Size(850, 110);
            this.panel_discord.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_discord.TabIndex = 0;
            // 
            // label_discord
            // 
            this.label_discord.AutoSize = true;
            this.label_discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label_discord.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_discord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label_discord.Location = new System.Drawing.Point(135, 41);
            this.label_discord.Name = "label_discord";
            this.label_discord.Size = new System.Drawing.Size(477, 28);
            this.label_discord.TabIndex = 1;
            this.label_discord.Text = "Discord sunucumuza katılmayı unutma !";
            // 
            // pictureBox_discord
            // 
            this.pictureBox_discord.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_discord.Image")));
            this.pictureBox_discord.Location = new System.Drawing.Point(30, 15);
            this.pictureBox_discord.Name = "pictureBox_discord";
            this.pictureBox_discord.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_discord.TabIndex = 0;
            this.pictureBox_discord.TabStop = false;
            this.pictureBox_discord.Click += new System.EventHandler(this.pictureBox_discord_Click);
            // 
            // elipse_discord
            // 
            this.elipse_discord.BorderRadius = 20;
            this.elipse_discord.TargetControl = this.panel_discord;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Animated = true;
            this.btn_minimize.BorderColor = System.Drawing.Color.Transparent;
            this.btn_minimize.CheckedState.Parent = this.btn_minimize;
            this.btn_minimize.CustomImages.Parent = this.btn_minimize;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.DisabledState.Parent = this.btn_minimize;
            this.btn_minimize.FillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.HoverState.Parent = this.btn_minimize;
            this.btn_minimize.Image = global::RowexaLauncher.Properties.Resources.minimize;
            this.btn_minimize.ImageOffset = new System.Drawing.Point(0, 6);
            this.btn_minimize.ImageSize = new System.Drawing.Size(30, 5);
            this.btn_minimize.Location = new System.Drawing.Point(1180, 15);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Parent = this.btn_minimize;
            this.btn_minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.BorderColor = System.Drawing.Color.Transparent;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.DisabledState.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Image = global::RowexaLauncher.Properties.Resources.close;
            this.btn_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_close.Location = new System.Drawing.Point(1230, 15);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 0;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel_welcome);
            this.Controls.Add(this.panel_news);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rowexa Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_news.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.panel_welcome.ResumeLayout(false);
            this.panel_discord.ResumeLayout(false);
            this.panel_discord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_discord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragControl__Main;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_minimize;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_launcherName;
        private ReaLTaiizor.Controls.Panel panel_main;
        private ReaLTaiizor.Controls.Panel panel_logo;
        private System.Windows.Forms.Button btn_news;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Panel panel_nav2;
        private ReaLTaiizor.Controls.Panel panel_news;
        private ReaLTaiizor.Controls.Panel panel_settings;
        private Guna.UI2.WinForms.Guna2Panel panel_login;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_offline;
        private Guna.UI2.WinForms.Guna2TextBox textBox_username;
        private Guna.UI2.WinForms.Guna2TextBox textBox_password;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.Label label_loginerror3;
        private System.Windows.Forms.Label label_loginerror2;
        private System.Windows.Forms.Label label_loginerror1;
        private System.Windows.Forms.Label label_username;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_version;
        private Guna.UI2.WinForms.Guna2TextBox textBox_res1;
        private System.Windows.Forms.Label label_res;
        private Guna.UI2.WinForms.Guna2TextBox textBox_res2;
        private System.Windows.Forms.Label label_resX;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_fullScreen;
        private System.Windows.Forms.Label label_ram;
        private System.Windows.Forms.Label label_ramMB;
        private Guna.UI2.WinForms.Guna2TextBox textBox_ram;
        private Guna.UI2.WinForms.Guna2Button btn_applySettings;
        private System.Windows.Forms.WebBrowser browser_updates;
        private ReaLTaiizor.Controls.Panel panel_welcome;
        private ReaLTaiizor.Controls.Panel panel_discord;
        private Guna.UI2.WinForms.Guna2Elipse elipse_discord;
        private System.Windows.Forms.PictureBox pictureBox_discord;
        private System.Windows.Forms.Label label_discord;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_snapshot;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_beta;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_alpha;
        private System.Windows.Forms.Label label_saveText;
    }
}