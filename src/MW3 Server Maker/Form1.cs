using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MW3_Server_Maker
{
    public partial class Form1 : MetroForm
    {
        private readonly string _configPath = $"{Environment.CurrentDirectory}\\config.mv";
        private readonly string _defaultPath = $"{Environment.CurrentDirectory}\\players2\\default.dspl";

        private Default _dspl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dspl = new Default(_defaultPath);
            if (File.Exists(_defaultPath))
            {
                _dspl.Read();
                foreach (var rotation in _dspl.Rotations)
                {
                    string[] result = rotation.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var map = Utils.FindMap(result[0].Trim());
                    var mod = Utils.FindMod(result[1].Trim());
                    var hc = result[1].Contains("Hardcore");
                    var priority = result[2].Trim();
                    listDspl.Items.Add(new ListViewItem(new string[] { map, mod, hc.ToString(), priority }));
                }
            }

            if (File.Exists(_configPath))
            {
                IniReader iniReader = new IniReader(_configPath);
                cb_map.Text = iniReader.ReadString("Server", "Map", "Aground");
                cb_mod.Text = iniReader.ReadString("Server", "Mod", "Capture The Flag");
                cb_hardCore.Text = iniReader.ReadString("Server", "HardCore", "Enable");
                cb_priority.Text = iniReader.ReadString("Server", "Priority", "1");
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
            _dspl.Write();
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
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (File.Exists("TeknoMW3_Server_Launcher.exe"))
            {
                IniReader iniReader = new IniReader(_configPath);
                iniReader.Write("Server", "Map", cb_map.Text);
                iniReader.Write("Server", "Mod", cb_mod.Text);
                iniReader.Write("Server", "HardCore", cb_hardCore.Text);
                iniReader.Write("Server", "Priority", cb_priority.Text);
                Process.Start("TeknoMW3_Server_Launcher.exe", "start_map_rotate");
                Application.Exit();
            }
            else
            {
                MetroMessageBox.Show(this, "\nTeknoMW3_Server_Launcher.exe Not Found!", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, $"Developer: Soheil Jashnsaz\nGithub: https://github.com/soheil-js\nRepository: https://github.com/soheil-js/MW3-Server-Maker\nVersion: {AppVersion.Get()}", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
