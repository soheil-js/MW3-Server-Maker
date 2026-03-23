using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MW3_Server_Maker
{
    public partial class FormSetting : MetroForm
    {
        private readonly Server _server;

        public FormSetting()
        {
            InitializeComponent();
            _server = new Server(PathProvider.CfgFilePath);
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            _server.Read();
            LoadConfig();
            LoadScripts();
            LoadCommands();
        }

        private void chk_loader1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScripts.Checked)
            {
                _server.HasScripts = true;
                txtScript.Enabled = true;
                listScripts.Enabled = true;
                btnAddScript.Enabled = true;
                btnClearScript.Enabled = true;
            }
            else
            {
                _server.HasScripts = false;
                txtScript.Enabled = false;
                listScripts.Enabled = false;
                btnAddScript.Enabled = false;
                btnClearScript.Enabled = false;
            }
        }

        private void chkCammand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCammand.Checked)
            {
                _server.HasCommands = true;
                txtCommand.Enabled = true;
                listCommands.Enabled = true;
                btnAddCommand.Enabled = true;
                btnCleaerCommand.Enabled = true;
            }
            else
            {
                _server.HasCommands = false;
                txtCommand.Enabled = false;
                listCommands.Enabled = false;
                btnAddCommand.Enabled = false;
                btnCleaerCommand.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SaveConfig();
            SaveScripts();
            SaveCommands();
            _server.Write();
            Close();
        }

        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void btnAddScript_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScript.Text))
            {
                _server.AddScript(txtScript.Text);
                listScripts.Items.Add(txtScript.Text.Trim());
                txtScript.Clear();
            }
        }

        private void btnClearScript_Click(object sender, EventArgs e)
        {
            _server.ClearScrips();
            listScripts.Items.Clear();
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCommand.Text))
            {
                _server.AddCommand(txtCommand.Text);
                listCommands.Items.Add(txtCommand.Text.Trim());
                txtCommand.Clear();
            }
        }

        private void btnCleaerCommand_Click(object sender, EventArgs e)
        {
            _server.ClearCommands();
            listCommands.Items.Clear();
        }

        private void LoadConfig()
        {
            txtHostName.Text = _server.HostName;
            txtMapRotation.Text = _server.MapRotation;
            txtMaxClients.Text = _server.MaxClients;
            txtServerPassword.Text = _server.Password;
            txtPrivateClients.Text = _server.PrivateClients;
            txtPrivatePassword.Text = _server.PrivatePassword;
            txtRconPassword.Text = _server.RconPassword;
            cboVoice.SelectedIndex = int.Parse(_server.Voice);
            cboAllowVote.SelectedIndex = int.Parse(_server.AllowVote);
            cboDeadChat.SelectedIndex = int.Parse(_server.DeadChat);
            txtInactivity.Text = _server.Inactivity;
            txtKickTime.Text = _server.KickBanTime;
            cboFloodProtect.SelectedIndex = int.Parse(_server.FloodProtect);
            txtMaxPing.Text = _server.MaxPing;
            cboBanByGuid.SelectedIndex = int.Parse(_server.BanByGuid);
            cboBanByIp.SelectedIndex = int.Parse(_server.BanByIp);
            txtClanWebsite.Text = _server.ClanWebsite;
            txtDiscord.Text = _server.Discord;
            txtFullMessage.Text = _server.ServerFullMessage;
            cbServerVisibility.SelectedIndex = int.Parse(_server.SpecifyServerVisibility) - 1;
            txtOpenGamePort.Text = _server.OpenGamePort;
            txtSecureGamePort.Text = _server.SecureGamePort;
            txtAuthPort.Text = _server.AuthenticationPort;
            txtMasterPort.Text = _server.MasterServerPort;

            if (_server.HasScripts)
            {
                chkScripts.Checked = true;
                chkScripts.CheckState = CheckState.Checked;
            }
            else
            {
                chkScripts.Checked = false;
                chkScripts.CheckState = CheckState.Unchecked;
            }

            if (_server.HasCommands)
            {
                chkCammand.Checked = true;
                chkCammand.CheckState = CheckState.Checked;
            }
            else
            {
                chkCammand.Checked = false;
                chkCammand.CheckState = CheckState.Unchecked;
            }
        }

        private void SaveConfig()
        {
            _server.HostName = txtHostName.Text;
            _server.MapRotation = txtMapRotation.Text;
            _server.MaxClients = txtMaxClients.Text;
            _server.Password = txtServerPassword.Text;
            _server.PrivateClients = txtPrivateClients.Text;
            _server.PrivatePassword = txtPrivatePassword.Text;
            _server.RconPassword = txtRconPassword.Text;
            _server.Voice = cboVoice.SelectedIndex.ToString();
            _server.AllowVote = cboAllowVote.SelectedIndex.ToString();
            _server.DeadChat = cboDeadChat.SelectedIndex.ToString();
            _server.Inactivity = txtInactivity.Text;
            _server.KickBanTime = txtKickTime.Text;
            _server.FloodProtect = cboFloodProtect.SelectedIndex.ToString();
            _server.MaxPing = txtMaxPing.Text;
            _server.BanByGuid = cboBanByGuid.SelectedIndex.ToString();
            _server.BanByIp = cboBanByIp.SelectedIndex.ToString();
            _server.ClanWebsite = txtClanWebsite.Text;
            _server.Discord = txtDiscord.Text;
            _server.ServerFullMessage = txtFullMessage.Text;
            _server.SpecifyServerVisibility = (cbServerVisibility.SelectedIndex + 1).ToString();
            _server.OpenGamePort = txtOpenGamePort.Text;
            _server.SecureGamePort = txtSecureGamePort.Text;
            _server.AuthenticationPort = txtAuthPort.Text;
            _server.MasterServerPort = txtMasterPort.Text;
        }

        private void LoadScripts()
        {
            if (File.Exists(PathProvider.ScriptsFilePath))
            {
                string[] scripts = File.ReadAllLines(PathProvider.ScriptsFilePath);
                foreach (string script in scripts)
                {
                    if (!string.IsNullOrEmpty(script))
                    {
                        listScripts.Items.Add(script);
                        _server.AddScript(script);
                    }
                }
            }
        }

        private void SaveScripts()
        {
            if (listScripts.Items.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(PathProvider.ScriptsFilePath, false))
                {
                    foreach (string script in listScripts.Items)
                    {
                        sw.WriteLine(script);
                    }
                }
            }
            else
            {
                File.Delete(PathProvider.ScriptsFilePath);
            }
        }

        private void LoadCommands()
        {
            if (File.Exists(PathProvider.CommandsFilePath))
            {
                string[] commands = File.ReadAllLines(PathProvider.CommandsFilePath);
                foreach (string command in commands)
                {
                    if (!string.IsNullOrEmpty(command))
                    {
                        listCommands.Items.Add(command);
                        _server.AddCommand(command);
                    }
                }

            }
        }

        private void SaveCommands()
        {
            if (listCommands.Items.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(PathProvider.CommandsFilePath, false))
                {
                    foreach (string command in listCommands.Items)
                    {
                        sw.WriteLine(command);
                    }
                }
            }
            else
            {
                File.Delete(PathProvider.CommandsFilePath);
            }
        }
    }
}
