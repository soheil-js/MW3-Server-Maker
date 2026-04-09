using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using MetroFramework;
using MetroFramework.Forms;

namespace MW3_Server_Maker
{
    public partial class FormMain : MetroForm
    {
        private readonly IniReader _iniReader;
        private readonly Default _dspl;

        public FormMain()
        {
            InitializeComponent();
            _iniReader = new IniReader(PathProvider.SettingsFilePath);
            _dspl = new Default(PathProvider.DsplFilePath);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(PathProvider.DsplFilePath))
            {
                _dspl.Read();
                foreach (var rotation in _dspl.Rotations)
                {
                    string[] result = rotation.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var map = Utils.FindMap(result[0].Trim());
                    var mod = Utils.FindMod(result[1].Trim());
                    var hc = result[1].Contains("HC");
                    var priority = result[2].Trim();
                    listDspl.Items.Add(new ListViewItem(new string[] { map, mod, hc.ToString(), priority }));
                }
            }

            if (File.Exists(PathProvider.SettingsFilePath))
            {
                cb_map.Text = _iniReader.ReadString("Server", "Map", "Aground");
                cb_mod.Text = _iniReader.ReadString("Server", "Mod", "Capture The Flag");
                cb_hardCore.Text = _iniReader.ReadString("Server", "HardCore", "Enable");
                cb_priority.Text = _iniReader.ReadString("Server", "Priority", "1");
            }
            else
            {
                cb_map.SelectedIndex = 0;
                cb_mod.SelectedIndex = 0;
                cb_hardCore.SelectedIndex = 0;
                cb_priority.SelectedIndex = 0;
            }
        }

        private void cb_map_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mapType = Utils.Map(cb_map.SelectedItem.ToString());
            pictureBox1.Image = Utils.Image(mapType);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            _dspl.Rotations.Clear();
            listDspl.Items.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string selectedMap = cb_map.SelectedItem.ToString();
            string selectedMod = cb_mod.SelectedItem.ToString();
            bool isHardCore = cb_hardCore.SelectedIndex == 0;
            string selectedPriority = cb_priority.SelectedItem.ToString();

            var mapType = Utils.Map(cb_map.SelectedItem.ToString());
            var map = Utils.Map(mapType);

            var modType = Utils.Mod(cb_mod.SelectedItem.ToString());
            var mod = Utils.Mod(modType, isHardCore);

            var priority = Utils.Priority(cb_priority.SelectedItem.ToString());

            _dspl.Add(map, mod, priority);
            listDspl.Items.Add(new ListViewItem(new string[] { selectedMap, selectedMod, (isHardCore).ToString(), selectedPriority }));
            _dspl.Write();
            save_settings();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (File.Exists("TeknoMW3_Server_Launcher.exe"))
            {
                List<string> args = new List<string>();
                if (chk_enable_slow_motion.Checked)
                    args.Add("-enable_slow_motion");
                if (chk_enable_rcon.Checked)
                    args.Add("-enable_rcon");
                if (chk_enable_b3.Checked)
                    args.Add("-enable_b3");
                if (chk_secure_b3.Checked)
                    args.Add("-secure_b3");
                if (chk_no_integrity.Checked)
                    args.Add("-no_integrity");
                if (chk_start_map_rotate.Checked)
                    args.Add("+start_map_rotate");

                Process.Start(PathProvider.LauncherFilePath, string.Join(" ", args));
                Application.Exit();
            }
            else
            {
                MetroMessageBox.Show(this, "\nTeknoMW3_Server_Launcher.exe Not Found!", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            FormOptions form2 = new FormOptions();
            form2.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, $"Developer: Soheil Jashnsaz\nGithub: https://github.com/soheil-js\nRepository: https://github.com/soheil-js/MW3-Server-Maker\nVersion: {AppVersion.Get()}", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void save_settings()
        {
            _iniReader.Write("Server", "Map", cb_map.Text);
            _iniReader.Write("Server", "Mod", cb_mod.Text);
            _iniReader.Write("Server", "HardCore", cb_hardCore.Text);
            _iniReader.Write("Server", "Priority", cb_priority.Text);
        }
    }
}
