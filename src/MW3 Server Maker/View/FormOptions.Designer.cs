namespace MW3_Server_Maker
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.chkScripts = new MetroFramework.Controls.MetroCheckBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtHostName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSecureGamePort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMasterPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtOpenGamePort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAuthPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPrivateClients = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMaxClients = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPrivatePassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbServerVisibility = new MetroFramework.Controls.MetroComboBox();
            this.txtRconPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtServerPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtInactivity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtTempBanTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.btnClearScript = new MetroFramework.Controls.MetroButton();
            this.btnAddScript = new MetroFramework.Controls.MetroButton();
            this.txtScript = new MetroFramework.Controls.MetroTextBox();
            this.chkCammand = new MetroFramework.Controls.MetroCheckBox();
            this.btnCleaerCommand = new MetroFramework.Controls.MetroButton();
            this.btnAddCommand = new MetroFramework.Controls.MetroButton();
            this.txtCommand = new MetroFramework.Controls.MetroTextBox();
            this.listScripts = new System.Windows.Forms.ListBox();
            this.listCommands = new System.Windows.Forms.ListBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtMapRotation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtClanWebsite = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtDiscord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.txtFullMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.cboVoice = new MetroFramework.Controls.MetroComboBox();
            this.cboAllowVote = new MetroFramework.Controls.MetroComboBox();
            this.cboDeadChat = new MetroFramework.Controls.MetroComboBox();
            this.cboFloodProtect = new MetroFramework.Controls.MetroComboBox();
            this.cboBanByGuid = new MetroFramework.Controls.MetroComboBox();
            this.cboBanByIp = new MetroFramework.Controls.MetroComboBox();
            this.txtMaxPing = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.cboFixedMapRotation = new MetroFramework.Controls.MetroComboBox();
            this.cboTeamAutoBalance = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.cboPlayerCollision = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.btnDefault = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // chkScripts
            // 
            this.chkScripts.AutoSize = true;
            this.chkScripts.Location = new System.Drawing.Point(31, 571);
            this.chkScripts.Margin = new System.Windows.Forms.Padding(4);
            this.chkScripts.Name = "chkScripts";
            this.chkScripts.Size = new System.Drawing.Size(63, 17);
            this.chkScripts.Style = MetroFramework.MetroColorStyle.Lime;
            this.chkScripts.TabIndex = 0;
            this.chkScripts.Text = "Scripts";
            this.chkScripts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkScripts.UseSelectable = true;
            this.chkScripts.CheckedChanged += new System.EventHandler(this.chkScripts_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 805);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(705, 43);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHostName
            // 
            // 
            // 
            // 
            this.txtHostName.CustomButton.Image = null;
            this.txtHostName.CustomButton.Location = new System.Drawing.Point(662, 2);
            this.txtHostName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.CustomButton.Name = "";
            this.txtHostName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHostName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHostName.CustomButton.TabIndex = 1;
            this.txtHostName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHostName.CustomButton.UseSelectable = true;
            this.txtHostName.CustomButton.Visible = false;
            this.txtHostName.Lines = new string[0];
            this.txtHostName.Location = new System.Drawing.Point(195, 71);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.MaxLength = 32767;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.PasswordChar = '\0';
            this.txtHostName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHostName.SelectedText = "";
            this.txtHostName.SelectionLength = 0;
            this.txtHostName.SelectionStart = 0;
            this.txtHostName.ShortcutsEnabled = true;
            this.txtHostName.Size = new System.Drawing.Size(690, 30);
            this.txtHostName.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtHostName.TabIndex = 5;
            this.txtHostName.UseSelectable = true;
            this.txtHostName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHostName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 74);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Server Name :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSecureGamePort
            // 
            // 
            // 
            // 
            this.txtSecureGamePort.CustomButton.Image = null;
            this.txtSecureGamePort.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtSecureGamePort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecureGamePort.CustomButton.Name = "";
            this.txtSecureGamePort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSecureGamePort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSecureGamePort.CustomButton.TabIndex = 1;
            this.txtSecureGamePort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSecureGamePort.CustomButton.UseSelectable = true;
            this.txtSecureGamePort.CustomButton.Visible = false;
            this.txtSecureGamePort.Lines = new string[0];
            this.txtSecureGamePort.Location = new System.Drawing.Point(785, 223);
            this.txtSecureGamePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecureGamePort.MaxLength = 32767;
            this.txtSecureGamePort.Name = "txtSecureGamePort";
            this.txtSecureGamePort.PasswordChar = '\0';
            this.txtSecureGamePort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecureGamePort.SelectedText = "";
            this.txtSecureGamePort.SelectionLength = 0;
            this.txtSecureGamePort.SelectionStart = 0;
            this.txtSecureGamePort.ShortcutsEnabled = true;
            this.txtSecureGamePort.Size = new System.Drawing.Size(100, 30);
            this.txtSecureGamePort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSecureGamePort.TabIndex = 5;
            this.txtSecureGamePort.UseSelectable = true;
            this.txtSecureGamePort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSecureGamePort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecureGamePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(598, 226);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Secure Game Port :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMasterPort
            // 
            // 
            // 
            // 
            this.txtMasterPort.CustomButton.Image = null;
            this.txtMasterPort.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtMasterPort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasterPort.CustomButton.Name = "";
            this.txtMasterPort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMasterPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterPort.CustomButton.TabIndex = 1;
            this.txtMasterPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterPort.CustomButton.UseSelectable = true;
            this.txtMasterPort.CustomButton.Visible = false;
            this.txtMasterPort.Lines = new string[0];
            this.txtMasterPort.Location = new System.Drawing.Point(195, 223);
            this.txtMasterPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasterPort.MaxLength = 32767;
            this.txtMasterPort.Name = "txtMasterPort";
            this.txtMasterPort.PasswordChar = '\0';
            this.txtMasterPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterPort.SelectedText = "";
            this.txtMasterPort.SelectionLength = 0;
            this.txtMasterPort.SelectionStart = 0;
            this.txtMasterPort.ShortcutsEnabled = true;
            this.txtMasterPort.Size = new System.Drawing.Size(100, 30);
            this.txtMasterPort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMasterPort.TabIndex = 5;
            this.txtMasterPort.UseSelectable = true;
            this.txtMasterPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMasterPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 226);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Master Port :";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtOpenGamePort
            // 
            // 
            // 
            // 
            this.txtOpenGamePort.CustomButton.Image = null;
            this.txtOpenGamePort.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtOpenGamePort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpenGamePort.CustomButton.Name = "";
            this.txtOpenGamePort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtOpenGamePort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpenGamePort.CustomButton.TabIndex = 1;
            this.txtOpenGamePort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpenGamePort.CustomButton.UseSelectable = true;
            this.txtOpenGamePort.CustomButton.Visible = false;
            this.txtOpenGamePort.Lines = new string[0];
            this.txtOpenGamePort.Location = new System.Drawing.Point(490, 223);
            this.txtOpenGamePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpenGamePort.MaxLength = 32767;
            this.txtOpenGamePort.Name = "txtOpenGamePort";
            this.txtOpenGamePort.PasswordChar = '\0';
            this.txtOpenGamePort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpenGamePort.SelectedText = "";
            this.txtOpenGamePort.SelectionLength = 0;
            this.txtOpenGamePort.SelectionStart = 0;
            this.txtOpenGamePort.ShortcutsEnabled = true;
            this.txtOpenGamePort.Size = new System.Drawing.Size(100, 30);
            this.txtOpenGamePort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtOpenGamePort.TabIndex = 5;
            this.txtOpenGamePort.UseSelectable = true;
            this.txtOpenGamePort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOpenGamePort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOpenGamePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(303, 226);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Open Game Port :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAuthPort
            // 
            // 
            // 
            // 
            this.txtAuthPort.CustomButton.Image = null;
            this.txtAuthPort.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtAuthPort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthPort.CustomButton.Name = "";
            this.txtAuthPort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAuthPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthPort.CustomButton.TabIndex = 1;
            this.txtAuthPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthPort.CustomButton.UseSelectable = true;
            this.txtAuthPort.CustomButton.Visible = false;
            this.txtAuthPort.Lines = new string[0];
            this.txtAuthPort.Location = new System.Drawing.Point(195, 261);
            this.txtAuthPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthPort.MaxLength = 32767;
            this.txtAuthPort.Name = "txtAuthPort";
            this.txtAuthPort.PasswordChar = '\0';
            this.txtAuthPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthPort.SelectedText = "";
            this.txtAuthPort.SelectionLength = 0;
            this.txtAuthPort.SelectionStart = 0;
            this.txtAuthPort.ShortcutsEnabled = true;
            this.txtAuthPort.Size = new System.Drawing.Size(100, 30);
            this.txtAuthPort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAuthPort.TabIndex = 5;
            this.txtAuthPort.UseSelectable = true;
            this.txtAuthPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAuthPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 262);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 20);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Auth Port :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrivateClients
            // 
            // 
            // 
            // 
            this.txtPrivateClients.CustomButton.Image = null;
            this.txtPrivateClients.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtPrivateClients.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateClients.CustomButton.Name = "";
            this.txtPrivateClients.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrivateClients.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrivateClients.CustomButton.TabIndex = 1;
            this.txtPrivateClients.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrivateClients.CustomButton.UseSelectable = true;
            this.txtPrivateClients.CustomButton.Visible = false;
            this.txtPrivateClients.Lines = new string[0];
            this.txtPrivateClients.Location = new System.Drawing.Point(785, 109);
            this.txtPrivateClients.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateClients.MaxLength = 32767;
            this.txtPrivateClients.Name = "txtPrivateClients";
            this.txtPrivateClients.PasswordChar = '\0';
            this.txtPrivateClients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrivateClients.SelectedText = "";
            this.txtPrivateClients.SelectionLength = 0;
            this.txtPrivateClients.SelectionStart = 0;
            this.txtPrivateClients.ShortcutsEnabled = true;
            this.txtPrivateClients.Size = new System.Drawing.Size(100, 30);
            this.txtPrivateClients.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrivateClients.TabIndex = 5;
            this.txtPrivateClients.UseSelectable = true;
            this.txtPrivateClients.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrivateClients.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrivateClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(598, 112);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 20);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Private Clients :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMaxClients
            // 
            // 
            // 
            // 
            this.txtMaxClients.CustomButton.Image = null;
            this.txtMaxClients.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtMaxClients.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxClients.CustomButton.Name = "";
            this.txtMaxClients.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMaxClients.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxClients.CustomButton.TabIndex = 1;
            this.txtMaxClients.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxClients.CustomButton.UseSelectable = true;
            this.txtMaxClients.CustomButton.Visible = false;
            this.txtMaxClients.Lines = new string[0];
            this.txtMaxClients.Location = new System.Drawing.Point(490, 109);
            this.txtMaxClients.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxClients.MaxLength = 32767;
            this.txtMaxClients.Name = "txtMaxClients";
            this.txtMaxClients.PasswordChar = '\0';
            this.txtMaxClients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxClients.SelectedText = "";
            this.txtMaxClients.SelectionLength = 0;
            this.txtMaxClients.SelectionStart = 0;
            this.txtMaxClients.ShortcutsEnabled = true;
            this.txtMaxClients.Size = new System.Drawing.Size(100, 30);
            this.txtMaxClients.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMaxClients.TabIndex = 5;
            this.txtMaxClients.UseSelectable = true;
            this.txtMaxClients.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxClients.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaxClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(303, 110);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 20);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Max Clients :";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(31, 492);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 20);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Server Visibility :";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrivatePassword
            // 
            // 
            // 
            // 
            this.txtPrivatePassword.CustomButton.Image = null;
            this.txtPrivatePassword.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtPrivatePassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivatePassword.CustomButton.Name = "";
            this.txtPrivatePassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrivatePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrivatePassword.CustomButton.TabIndex = 1;
            this.txtPrivatePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrivatePassword.CustomButton.UseSelectable = true;
            this.txtPrivatePassword.CustomButton.Visible = false;
            this.txtPrivatePassword.Lines = new string[0];
            this.txtPrivatePassword.Location = new System.Drawing.Point(785, 147);
            this.txtPrivatePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivatePassword.MaxLength = 32767;
            this.txtPrivatePassword.Name = "txtPrivatePassword";
            this.txtPrivatePassword.PasswordChar = '\0';
            this.txtPrivatePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrivatePassword.SelectedText = "";
            this.txtPrivatePassword.SelectionLength = 0;
            this.txtPrivatePassword.SelectionStart = 0;
            this.txtPrivatePassword.ShortcutsEnabled = true;
            this.txtPrivatePassword.Size = new System.Drawing.Size(100, 30);
            this.txtPrivatePassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrivatePassword.TabIndex = 5;
            this.txtPrivatePassword.UseSelectable = true;
            this.txtPrivatePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrivatePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(598, 150);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 20);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Private Password :";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbServerVisibility
            // 
            this.cbServerVisibility.FormattingEnabled = true;
            this.cbServerVisibility.ItemHeight = 24;
            this.cbServerVisibility.Items.AddRange(new object[] {
            "Lan",
            "Internet"});
            this.cbServerVisibility.Location = new System.Drawing.Point(195, 491);
            this.cbServerVisibility.Margin = new System.Windows.Forms.Padding(4);
            this.cbServerVisibility.Name = "cbServerVisibility";
            this.cbServerVisibility.Size = new System.Drawing.Size(100, 30);
            this.cbServerVisibility.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbServerVisibility.TabIndex = 7;
            this.cbServerVisibility.UseSelectable = true;
            // 
            // txtRconPassword
            // 
            // 
            // 
            // 
            this.txtRconPassword.CustomButton.Image = null;
            this.txtRconPassword.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtRconPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtRconPassword.CustomButton.Name = "";
            this.txtRconPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtRconPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRconPassword.CustomButton.TabIndex = 1;
            this.txtRconPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRconPassword.CustomButton.UseSelectable = true;
            this.txtRconPassword.CustomButton.Visible = false;
            this.txtRconPassword.Lines = new string[0];
            this.txtRconPassword.Location = new System.Drawing.Point(195, 147);
            this.txtRconPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRconPassword.MaxLength = 32767;
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.PasswordChar = '\0';
            this.txtRconPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRconPassword.SelectedText = "";
            this.txtRconPassword.SelectionLength = 0;
            this.txtRconPassword.SelectionStart = 0;
            this.txtRconPassword.ShortcutsEnabled = true;
            this.txtRconPassword.Size = new System.Drawing.Size(100, 30);
            this.txtRconPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtRconPassword.TabIndex = 5;
            this.txtRconPassword.UseSelectable = true;
            this.txtRconPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRconPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(31, 149);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(116, 20);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "RCON Password :";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtServerPassword
            // 
            // 
            // 
            // 
            this.txtServerPassword.CustomButton.Image = null;
            this.txtServerPassword.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtServerPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerPassword.CustomButton.Name = "";
            this.txtServerPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtServerPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerPassword.CustomButton.TabIndex = 1;
            this.txtServerPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerPassword.CustomButton.UseSelectable = true;
            this.txtServerPassword.CustomButton.Visible = false;
            this.txtServerPassword.Lines = new string[0];
            this.txtServerPassword.Location = new System.Drawing.Point(490, 147);
            this.txtServerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerPassword.MaxLength = 32767;
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.PasswordChar = '\0';
            this.txtServerPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerPassword.SelectedText = "";
            this.txtServerPassword.SelectionLength = 0;
            this.txtServerPassword.SelectionStart = 0;
            this.txtServerPassword.ShortcutsEnabled = true;
            this.txtServerPassword.Size = new System.Drawing.Size(100, 30);
            this.txtServerPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtServerPassword.TabIndex = 5;
            this.txtServerPassword.UseSelectable = true;
            this.txtServerPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(303, 150);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(118, 20);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "Server Password :";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(303, 417);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(82, 20);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel12.TabIndex = 6;
            this.metroLabel12.Text = "Voice Chat :";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(598, 417);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(81, 20);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel13.TabIndex = 6;
            this.metroLabel13.Text = "Allow Vote :";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(31, 418);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 20);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "Dead Chat :";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtInactivity
            // 
            // 
            // 
            // 
            this.txtInactivity.CustomButton.Image = null;
            this.txtInactivity.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtInactivity.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtInactivity.CustomButton.Name = "";
            this.txtInactivity.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtInactivity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInactivity.CustomButton.TabIndex = 1;
            this.txtInactivity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInactivity.CustomButton.UseSelectable = true;
            this.txtInactivity.CustomButton.Visible = false;
            this.txtInactivity.Lines = new string[0];
            this.txtInactivity.Location = new System.Drawing.Point(490, 185);
            this.txtInactivity.Margin = new System.Windows.Forms.Padding(4);
            this.txtInactivity.MaxLength = 32767;
            this.txtInactivity.Name = "txtInactivity";
            this.txtInactivity.PasswordChar = '\0';
            this.txtInactivity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInactivity.SelectedText = "";
            this.txtInactivity.SelectionLength = 0;
            this.txtInactivity.SelectionStart = 0;
            this.txtInactivity.ShortcutsEnabled = true;
            this.txtInactivity.Size = new System.Drawing.Size(100, 30);
            this.txtInactivity.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtInactivity.TabIndex = 5;
            this.txtInactivity.UseSelectable = true;
            this.txtInactivity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInactivity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInactivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(303, 188);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(69, 20);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel15.TabIndex = 6;
            this.metroLabel15.Text = "Inactivity :";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTempBanTime
            // 
            // 
            // 
            // 
            this.txtTempBanTime.CustomButton.Image = null;
            this.txtTempBanTime.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtTempBanTime.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempBanTime.CustomButton.Name = "";
            this.txtTempBanTime.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTempBanTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTempBanTime.CustomButton.TabIndex = 1;
            this.txtTempBanTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTempBanTime.CustomButton.UseSelectable = true;
            this.txtTempBanTime.CustomButton.Visible = false;
            this.txtTempBanTime.Lines = new string[0];
            this.txtTempBanTime.Location = new System.Drawing.Point(785, 185);
            this.txtTempBanTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempBanTime.MaxLength = 32767;
            this.txtTempBanTime.Name = "txtTempBanTime";
            this.txtTempBanTime.PasswordChar = '\0';
            this.txtTempBanTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempBanTime.SelectedText = "";
            this.txtTempBanTime.SelectionLength = 0;
            this.txtTempBanTime.SelectionStart = 0;
            this.txtTempBanTime.ShortcutsEnabled = true;
            this.txtTempBanTime.Size = new System.Drawing.Size(100, 30);
            this.txtTempBanTime.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtTempBanTime.TabIndex = 5;
            this.txtTempBanTime.UseSelectable = true;
            this.txtTempBanTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTempBanTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTempBanTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(598, 188);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(112, 20);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel16.TabIndex = 6;
            this.metroLabel16.Text = "Temp Ban Time :";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClearScript
            // 
            this.btnClearScript.Enabled = false;
            this.btnClearScript.Location = new System.Drawing.Point(182, 740);
            this.btnClearScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(143, 43);
            this.btnClearScript.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnClearScript.TabIndex = 4;
            this.btnClearScript.Text = "Clear";
            this.btnClearScript.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearScript.UseSelectable = true;
            this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
            // 
            // btnAddScript
            // 
            this.btnAddScript.Enabled = false;
            this.btnAddScript.Location = new System.Drawing.Point(31, 740);
            this.btnAddScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(143, 43);
            this.btnAddScript.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAddScript.TabIndex = 4;
            this.btnAddScript.Text = "Add";
            this.btnAddScript.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddScript.UseSelectable = true;
            this.btnAddScript.Click += new System.EventHandler(this.btnAddScript_Click);
            // 
            // txtScript
            // 
            // 
            // 
            // 
            this.txtScript.CustomButton.Image = null;
            this.txtScript.CustomButton.Location = new System.Drawing.Point(395, 2);
            this.txtScript.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtScript.CustomButton.Name = "";
            this.txtScript.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtScript.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtScript.CustomButton.TabIndex = 1;
            this.txtScript.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtScript.CustomButton.UseSelectable = true;
            this.txtScript.CustomButton.Visible = false;
            this.txtScript.Enabled = false;
            this.txtScript.Lines = new string[0];
            this.txtScript.Location = new System.Drawing.Point(31, 596);
            this.txtScript.Margin = new System.Windows.Forms.Padding(4);
            this.txtScript.MaxLength = 32767;
            this.txtScript.Name = "txtScript";
            this.txtScript.PasswordChar = '\0';
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtScript.SelectedText = "";
            this.txtScript.SelectionLength = 0;
            this.txtScript.SelectionStart = 0;
            this.txtScript.ShortcutsEnabled = true;
            this.txtScript.Size = new System.Drawing.Size(423, 30);
            this.txtScript.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtScript.TabIndex = 11;
            this.txtScript.UseSelectable = true;
            this.txtScript.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtScript.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkCammand
            // 
            this.chkCammand.AutoSize = true;
            this.chkCammand.Location = new System.Drawing.Point(462, 571);
            this.chkCammand.Margin = new System.Windows.Forms.Padding(4);
            this.chkCammand.Name = "chkCammand";
            this.chkCammand.Size = new System.Drawing.Size(90, 17);
            this.chkCammand.Style = MetroFramework.MetroColorStyle.Lime;
            this.chkCammand.TabIndex = 0;
            this.chkCammand.Text = "Commands";
            this.chkCammand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkCammand.UseSelectable = true;
            this.chkCammand.CheckedChanged += new System.EventHandler(this.chkCammand_CheckedChanged);
            // 
            // btnCleaerCommand
            // 
            this.btnCleaerCommand.Enabled = false;
            this.btnCleaerCommand.Location = new System.Drawing.Point(613, 740);
            this.btnCleaerCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleaerCommand.Name = "btnCleaerCommand";
            this.btnCleaerCommand.Size = new System.Drawing.Size(143, 43);
            this.btnCleaerCommand.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCleaerCommand.TabIndex = 4;
            this.btnCleaerCommand.Text = "Clear";
            this.btnCleaerCommand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCleaerCommand.UseSelectable = true;
            this.btnCleaerCommand.Click += new System.EventHandler(this.btnCleaerCommand_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Enabled = false;
            this.btnAddCommand.Location = new System.Drawing.Point(462, 740);
            this.btnAddCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(143, 43);
            this.btnAddCommand.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAddCommand.TabIndex = 4;
            this.btnAddCommand.Text = "Add";
            this.btnAddCommand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddCommand.UseSelectable = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // txtCommand
            // 
            // 
            // 
            // 
            this.txtCommand.CustomButton.Image = null;
            this.txtCommand.CustomButton.Location = new System.Drawing.Point(395, 2);
            this.txtCommand.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.CustomButton.Name = "";
            this.txtCommand.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCommand.CustomButton.TabIndex = 1;
            this.txtCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCommand.CustomButton.UseSelectable = true;
            this.txtCommand.CustomButton.Visible = false;
            this.txtCommand.Enabled = false;
            this.txtCommand.Lines = new string[0];
            this.txtCommand.Location = new System.Drawing.Point(462, 596);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.MaxLength = 32767;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.PasswordChar = '\0';
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommand.SelectedText = "";
            this.txtCommand.SelectionLength = 0;
            this.txtCommand.SelectionStart = 0;
            this.txtCommand.ShortcutsEnabled = true;
            this.txtCommand.Size = new System.Drawing.Size(423, 30);
            this.txtCommand.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtCommand.TabIndex = 11;
            this.txtCommand.UseSelectable = true;
            this.txtCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listScripts
            // 
            this.listScripts.Enabled = false;
            this.listScripts.FormattingEnabled = true;
            this.listScripts.ItemHeight = 16;
            this.listScripts.Location = new System.Drawing.Point(31, 632);
            this.listScripts.Margin = new System.Windows.Forms.Padding(4);
            this.listScripts.Name = "listScripts";
            this.listScripts.Size = new System.Drawing.Size(423, 100);
            this.listScripts.TabIndex = 12;
            // 
            // listCommands
            // 
            this.listCommands.Enabled = false;
            this.listCommands.FormattingEnabled = true;
            this.listCommands.ItemHeight = 16;
            this.listCommands.Location = new System.Drawing.Point(462, 632);
            this.listCommands.Margin = new System.Windows.Forms.Padding(4);
            this.listCommands.Name = "listCommands";
            this.listCommands.Size = new System.Drawing.Size(423, 100);
            this.listCommands.TabIndex = 12;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(31, 112);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(93, 20);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel17.TabIndex = 14;
            this.metroLabel17.Text = "Map Rotation:";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMapRotation
            // 
            // 
            // 
            // 
            this.txtMapRotation.CustomButton.Image = null;
            this.txtMapRotation.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtMapRotation.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMapRotation.CustomButton.Name = "";
            this.txtMapRotation.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMapRotation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMapRotation.CustomButton.TabIndex = 1;
            this.txtMapRotation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMapRotation.CustomButton.UseSelectable = true;
            this.txtMapRotation.CustomButton.Visible = false;
            this.txtMapRotation.Lines = new string[0];
            this.txtMapRotation.Location = new System.Drawing.Point(195, 109);
            this.txtMapRotation.Margin = new System.Windows.Forms.Padding(4);
            this.txtMapRotation.MaxLength = 32767;
            this.txtMapRotation.Name = "txtMapRotation";
            this.txtMapRotation.PasswordChar = '\0';
            this.txtMapRotation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMapRotation.SelectedText = "";
            this.txtMapRotation.SelectionLength = 0;
            this.txtMapRotation.SelectionStart = 0;
            this.txtMapRotation.ShortcutsEnabled = true;
            this.txtMapRotation.Size = new System.Drawing.Size(100, 30);
            this.txtMapRotation.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMapRotation.TabIndex = 13;
            this.txtMapRotation.UseSelectable = true;
            this.txtMapRotation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMapRotation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(598, 455);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(98, 20);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel18.TabIndex = 15;
            this.metroLabel18.Text = "Flood Protect :";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(31, 188);
            this.metroLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(72, 20);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel19.TabIndex = 17;
            this.metroLabel19.Text = "Max Ping :";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(31, 302);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(96, 20);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel20.TabIndex = 20;
            this.metroLabel20.Text = "Clan Website :";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtClanWebsite
            // 
            // 
            // 
            // 
            this.txtClanWebsite.CustomButton.Image = null;
            this.txtClanWebsite.CustomButton.Location = new System.Drawing.Point(662, 2);
            this.txtClanWebsite.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtClanWebsite.CustomButton.Name = "";
            this.txtClanWebsite.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClanWebsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClanWebsite.CustomButton.TabIndex = 1;
            this.txtClanWebsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClanWebsite.CustomButton.UseSelectable = true;
            this.txtClanWebsite.CustomButton.Visible = false;
            this.txtClanWebsite.Lines = new string[0];
            this.txtClanWebsite.Location = new System.Drawing.Point(195, 299);
            this.txtClanWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.txtClanWebsite.MaxLength = 32767;
            this.txtClanWebsite.Name = "txtClanWebsite";
            this.txtClanWebsite.PasswordChar = '\0';
            this.txtClanWebsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClanWebsite.SelectedText = "";
            this.txtClanWebsite.SelectionLength = 0;
            this.txtClanWebsite.SelectionStart = 0;
            this.txtClanWebsite.ShortcutsEnabled = true;
            this.txtClanWebsite.Size = new System.Drawing.Size(690, 30);
            this.txtClanWebsite.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtClanWebsite.TabIndex = 19;
            this.txtClanWebsite.UseSelectable = true;
            this.txtClanWebsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClanWebsite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(31, 340);
            this.metroLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(63, 20);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel21.TabIndex = 24;
            this.metroLabel21.Text = "Discord :";
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDiscord
            // 
            // 
            // 
            // 
            this.txtDiscord.CustomButton.Image = null;
            this.txtDiscord.CustomButton.Location = new System.Drawing.Point(662, 2);
            this.txtDiscord.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscord.CustomButton.Name = "";
            this.txtDiscord.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDiscord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscord.CustomButton.TabIndex = 1;
            this.txtDiscord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscord.CustomButton.UseSelectable = true;
            this.txtDiscord.CustomButton.Visible = false;
            this.txtDiscord.Lines = new string[0];
            this.txtDiscord.Location = new System.Drawing.Point(195, 337);
            this.txtDiscord.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscord.MaxLength = 32767;
            this.txtDiscord.Name = "txtDiscord";
            this.txtDiscord.PasswordChar = '\0';
            this.txtDiscord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscord.SelectedText = "";
            this.txtDiscord.SelectionLength = 0;
            this.txtDiscord.SelectionStart = 0;
            this.txtDiscord.ShortcutsEnabled = true;
            this.txtDiscord.Size = new System.Drawing.Size(690, 30);
            this.txtDiscord.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDiscord.TabIndex = 23;
            this.txtDiscord.UseSelectable = true;
            this.txtDiscord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(31, 378);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(96, 20);
            this.metroLabel22.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel22.TabIndex = 26;
            this.metroLabel22.Text = "Full Message :";
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFullMessage
            // 
            // 
            // 
            // 
            this.txtFullMessage.CustomButton.Image = null;
            this.txtFullMessage.CustomButton.Location = new System.Drawing.Point(662, 2);
            this.txtFullMessage.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullMessage.CustomButton.Name = "";
            this.txtFullMessage.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFullMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullMessage.CustomButton.TabIndex = 1;
            this.txtFullMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullMessage.CustomButton.UseSelectable = true;
            this.txtFullMessage.CustomButton.Visible = false;
            this.txtFullMessage.Lines = new string[0];
            this.txtFullMessage.Location = new System.Drawing.Point(195, 375);
            this.txtFullMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullMessage.MaxLength = 32767;
            this.txtFullMessage.Name = "txtFullMessage";
            this.txtFullMessage.PasswordChar = '\0';
            this.txtFullMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullMessage.SelectedText = "";
            this.txtFullMessage.SelectionLength = 0;
            this.txtFullMessage.SelectionStart = 0;
            this.txtFullMessage.ShortcutsEnabled = true;
            this.txtFullMessage.Size = new System.Drawing.Size(690, 30);
            this.txtFullMessage.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFullMessage.TabIndex = 25;
            this.txtFullMessage.UseSelectable = true;
            this.txtFullMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(303, 453);
            this.metroLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(95, 20);
            this.metroLabel23.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel23.TabIndex = 28;
            this.metroLabel23.Text = "Ban By GUID :";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(32, 455);
            this.metroLabel24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(73, 20);
            this.metroLabel24.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel24.TabIndex = 30;
            this.metroLabel24.Text = "Ban By IP :";
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboVoice
            // 
            this.cboVoice.FormattingEnabled = true;
            this.cboVoice.ItemHeight = 24;
            this.cboVoice.Items.AddRange(new object[] {
            "No",
            "Free",
            "Team"});
            this.cboVoice.Location = new System.Drawing.Point(490, 413);
            this.cboVoice.Margin = new System.Windows.Forms.Padding(4);
            this.cboVoice.Name = "cboVoice";
            this.cboVoice.Size = new System.Drawing.Size(100, 30);
            this.cboVoice.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboVoice.TabIndex = 31;
            this.cboVoice.UseSelectable = true;
            // 
            // cboAllowVote
            // 
            this.cboAllowVote.FormattingEnabled = true;
            this.cboAllowVote.ItemHeight = 24;
            this.cboAllowVote.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboAllowVote.Location = new System.Drawing.Point(785, 413);
            this.cboAllowVote.Margin = new System.Windows.Forms.Padding(4);
            this.cboAllowVote.Name = "cboAllowVote";
            this.cboAllowVote.Size = new System.Drawing.Size(100, 30);
            this.cboAllowVote.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboAllowVote.TabIndex = 32;
            this.cboAllowVote.UseSelectable = true;
            // 
            // cboDeadChat
            // 
            this.cboDeadChat.FormattingEnabled = true;
            this.cboDeadChat.ItemHeight = 24;
            this.cboDeadChat.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboDeadChat.Location = new System.Drawing.Point(195, 413);
            this.cboDeadChat.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeadChat.Name = "cboDeadChat";
            this.cboDeadChat.Size = new System.Drawing.Size(100, 30);
            this.cboDeadChat.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboDeadChat.TabIndex = 33;
            this.cboDeadChat.UseSelectable = true;
            // 
            // cboFloodProtect
            // 
            this.cboFloodProtect.FormattingEnabled = true;
            this.cboFloodProtect.ItemHeight = 24;
            this.cboFloodProtect.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboFloodProtect.Location = new System.Drawing.Point(785, 451);
            this.cboFloodProtect.Margin = new System.Windows.Forms.Padding(4);
            this.cboFloodProtect.Name = "cboFloodProtect";
            this.cboFloodProtect.Size = new System.Drawing.Size(100, 30);
            this.cboFloodProtect.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboFloodProtect.TabIndex = 34;
            this.cboFloodProtect.UseSelectable = true;
            // 
            // cboBanByGuid
            // 
            this.cboBanByGuid.FormattingEnabled = true;
            this.cboBanByGuid.ItemHeight = 24;
            this.cboBanByGuid.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboBanByGuid.Location = new System.Drawing.Point(490, 451);
            this.cboBanByGuid.Margin = new System.Windows.Forms.Padding(4);
            this.cboBanByGuid.Name = "cboBanByGuid";
            this.cboBanByGuid.Size = new System.Drawing.Size(100, 30);
            this.cboBanByGuid.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboBanByGuid.TabIndex = 36;
            this.cboBanByGuid.UseSelectable = true;
            // 
            // cboBanByIp
            // 
            this.cboBanByIp.FormattingEnabled = true;
            this.cboBanByIp.ItemHeight = 24;
            this.cboBanByIp.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboBanByIp.Location = new System.Drawing.Point(195, 453);
            this.cboBanByIp.Margin = new System.Windows.Forms.Padding(4);
            this.cboBanByIp.Name = "cboBanByIp";
            this.cboBanByIp.Size = new System.Drawing.Size(100, 30);
            this.cboBanByIp.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboBanByIp.TabIndex = 37;
            this.cboBanByIp.UseSelectable = true;
            // 
            // txtMaxPing
            // 
            // 
            // 
            // 
            this.txtMaxPing.CustomButton.Image = null;
            this.txtMaxPing.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.txtMaxPing.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxPing.CustomButton.Name = "";
            this.txtMaxPing.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMaxPing.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxPing.CustomButton.TabIndex = 1;
            this.txtMaxPing.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxPing.CustomButton.UseSelectable = true;
            this.txtMaxPing.CustomButton.Visible = false;
            this.txtMaxPing.Lines = new string[0];
            this.txtMaxPing.Location = new System.Drawing.Point(195, 185);
            this.txtMaxPing.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxPing.MaxLength = 32767;
            this.txtMaxPing.Name = "txtMaxPing";
            this.txtMaxPing.PasswordChar = '\0';
            this.txtMaxPing.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxPing.SelectedText = "";
            this.txtMaxPing.SelectionLength = 0;
            this.txtMaxPing.SelectionStart = 0;
            this.txtMaxPing.ShortcutsEnabled = true;
            this.txtMaxPing.Size = new System.Drawing.Size(100, 30);
            this.txtMaxPing.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMaxPing.TabIndex = 38;
            this.txtMaxPing.UseSelectable = true;
            this.txtMaxPing.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxPing.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaxPing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(303, 492);
            this.metroLabel25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(133, 20);
            this.metroLabel25.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel25.TabIndex = 39;
            this.metroLabel25.Text = "Fixed Map Rotation :";
            this.metroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboFixedMapRotation
            // 
            this.cboFixedMapRotation.FormattingEnabled = true;
            this.cboFixedMapRotation.ItemHeight = 24;
            this.cboFixedMapRotation.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboFixedMapRotation.Location = new System.Drawing.Point(490, 489);
            this.cboFixedMapRotation.Margin = new System.Windows.Forms.Padding(4);
            this.cboFixedMapRotation.Name = "cboFixedMapRotation";
            this.cboFixedMapRotation.Size = new System.Drawing.Size(100, 30);
            this.cboFixedMapRotation.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboFixedMapRotation.TabIndex = 40;
            this.cboFixedMapRotation.UseSelectable = true;
            // 
            // cboTeamAutoBalance
            // 
            this.cboTeamAutoBalance.FormattingEnabled = true;
            this.cboTeamAutoBalance.ItemHeight = 24;
            this.cboTeamAutoBalance.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboTeamAutoBalance.Location = new System.Drawing.Point(785, 489);
            this.cboTeamAutoBalance.Margin = new System.Windows.Forms.Padding(4);
            this.cboTeamAutoBalance.Name = "cboTeamAutoBalance";
            this.cboTeamAutoBalance.Size = new System.Drawing.Size(100, 30);
            this.cboTeamAutoBalance.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboTeamAutoBalance.TabIndex = 42;
            this.cboTeamAutoBalance.UseSelectable = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(598, 492);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(136, 20);
            this.metroLabel26.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel26.TabIndex = 41;
            this.metroLabel26.Text = "Team Auto-Balance :";
            this.metroLabel26.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboPlayerCollision
            // 
            this.cboPlayerCollision.FormattingEnabled = true;
            this.cboPlayerCollision.ItemHeight = 24;
            this.cboPlayerCollision.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboPlayerCollision.Location = new System.Drawing.Point(195, 529);
            this.cboPlayerCollision.Margin = new System.Windows.Forms.Padding(4);
            this.cboPlayerCollision.Name = "cboPlayerCollision";
            this.cboPlayerCollision.Size = new System.Drawing.Size(100, 30);
            this.cboPlayerCollision.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboPlayerCollision.TabIndex = 44;
            this.cboPlayerCollision.UseSelectable = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(31, 530);
            this.metroLabel27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(109, 20);
            this.metroLabel27.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel27.TabIndex = 43;
            this.metroLabel27.Text = "Player Collision :";
            this.metroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(743, 805);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(143, 43);
            this.btnDefault.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnDefault.TabIndex = 45;
            this.btnDefault.Text = "Default";
            this.btnDefault.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDefault.UseSelectable = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 876);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.cboPlayerCollision);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.cboTeamAutoBalance);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.cboFixedMapRotation);
            this.Controls.Add(this.metroLabel25);
            this.Controls.Add(this.txtMaxPing);
            this.Controls.Add(this.cboBanByIp);
            this.Controls.Add(this.cboBanByGuid);
            this.Controls.Add(this.cboFloodProtect);
            this.Controls.Add(this.cboDeadChat);
            this.Controls.Add(this.cboAllowVote);
            this.Controls.Add(this.cboVoice);
            this.Controls.Add(this.metroLabel24);
            this.Controls.Add(this.metroLabel23);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.txtFullMessage);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.txtDiscord);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.txtClanWebsite);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.txtMapRotation);
            this.Controls.Add(this.listCommands);
            this.Controls.Add(this.listScripts);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.cbServerVisibility);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtTempBanTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtInactivity);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtServerPassword);
            this.Controls.Add(this.txtRconPassword);
            this.Controls.Add(this.txtPrivatePassword);
            this.Controls.Add(this.txtMaxClients);
            this.Controls.Add(this.txtPrivateClients);
            this.Controls.Add(this.txtAuthPort);
            this.Controls.Add(this.txtOpenGamePort);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtMasterPort);
            this.Controls.Add(this.txtSecureGamePort);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnAddScript);
            this.Controls.Add(this.btnCleaerCommand);
            this.Controls.Add(this.btnClearScript);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkCammand);
            this.Controls.Add(this.chkScripts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Options";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkScripts;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtHostName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSecureGamePort;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMasterPort;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtOpenGamePort;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAuthPort;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPrivateClients;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtMaxClients;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPrivatePassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cbServerVisibility;
        private MetroFramework.Controls.MetroTextBox txtRconPassword;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtServerPassword;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtInactivity;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtTempBanTime;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton btnClearScript;
        private MetroFramework.Controls.MetroButton btnAddScript;
        private MetroFramework.Controls.MetroTextBox txtScript;
        private MetroFramework.Controls.MetroCheckBox chkCammand;
        private MetroFramework.Controls.MetroButton btnCleaerCommand;
        private MetroFramework.Controls.MetroButton btnAddCommand;
        private MetroFramework.Controls.MetroTextBox txtCommand;
        private System.Windows.Forms.ListBox listScripts;
        private System.Windows.Forms.ListBox listCommands;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtMapRotation;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtClanWebsite;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtDiscord;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroTextBox txtFullMessage;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroComboBox cboVoice;
        private MetroFramework.Controls.MetroComboBox cboAllowVote;
        private MetroFramework.Controls.MetroComboBox cboDeadChat;
        private MetroFramework.Controls.MetroComboBox cboFloodProtect;
        private MetroFramework.Controls.MetroComboBox cboBanByGuid;
        private MetroFramework.Controls.MetroComboBox cboBanByIp;
        private MetroFramework.Controls.MetroTextBox txtMaxPing;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroComboBox cboFixedMapRotation;
        private MetroFramework.Controls.MetroComboBox cboTeamAutoBalance;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroComboBox cboPlayerCollision;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroButton btnDefault;
    }
}