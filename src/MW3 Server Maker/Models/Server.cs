using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MW3_Server_Maker
{
    internal class Server
    {
        private readonly string _path;
        private List<string> scripts = new List<string>();
        private List<string> commands = new List<string>();

        public bool HasScripts { get; set; }
        public bool HasCommands { get; set; }

        public string SpecifyServerVisibility { get; set; }
        public string OpenGamePort { get; set; }
        public string SecureGamePort { get; set; }
        public string AuthenticationPort { get; set; }
        public string MasterServerPort { get; set; }
        public string HostName { get; set; }
        public string MapRotation { get; set; }
        public string FixedMapRotation { get; set; }
        public string MaxClients { get; set; }
        public string Password { get; set; }
        public string PrivateClients { get; set; }
        public string PrivatePassword { get; set; }
        public string RconPassword { get; set; }
        public string Voice { get; set; }
        public string AllowVote { get; set; }
        public string DeadChat { get; set; }
        public string Inactivity { get; set; }
        public string TempBanTime { get; set; }
        public string FloodProtect { get; set; }
        public string MaxPing { get; set; }
        public string ClanWebsite { get; set; }
        public string Discord { get; set; }
        public string ServerFullMessage { get; set; }
        public string BanByGuid { get; set; }
        public string BanByIp { get; set; }
        public string TeamAutoBalance { get; set; }
        public string PlayerCollision { get; set; }

        public Server(string path)
        {
            _path = path;
            SetDefaultValue();
        }

        public void SetDefaultValue()
        {
            SpecifyServerVisibility = "1";
            OpenGamePort = "27015";
            SecureGamePort = "27016";
            AuthenticationPort = "8766";
            MasterServerPort = "27017";
            HostName = "MVSoft";
            MapRotation = "Default";
            FixedMapRotation = "0";
            MaxClients = "18";
            Password = "";
            PrivateClients = "";
            PrivatePassword = "";
            RconPassword = "1234";
            Voice = "2";
            AllowVote = "0";
            DeadChat = "0";
            Inactivity = "0";
            TempBanTime = "3600";
            FloodProtect = "1";
            MaxPing = "500";
            ClanWebsite = "https://github.com/soheil-js";
            Discord = "https://discord.gg/HbG3kQ5";
            ServerFullMessage = "The server is full. Come back later.";
            BanByGuid = "0";
            BanByIp = "0";
            TeamAutoBalance = "0";
            PlayerCollision = "1";
        }

        public void AddScript(string name)
        {
            scripts.Add(name);
        }

        public void ClearScrips()
        {
            scripts.Clear();
        }

        public void AddCommand(string name)
        {
            commands.Add(name);
        }

        public void ClearCommands()
        {
            commands.Clear();
        }

        public void Read()
        {
            if (File.Exists(_path))
            {
                string[] lines = File.ReadAllLines(_path);
                HasScripts = !lines.Any(x => x.Contains("//loadScript \"MyScript.dll\""));
                HasCommands = lines.Any(x => x.Contains("//Other Command"));
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("//"))
                    {
                        if (line.Contains("sv_hostname"))
                        {
                            var result = Regex.Match(line, "seta sv_hostname \"(.*?)\"");
                            if (result.Success)
                                HostName = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_maprotation"))
                        {
                            var result = Regex.Match(line, "seta sv_maprotation \"(.*?)\"");
                            if (result.Success)
                                MapRotation = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_fixedMapRotation"))
                        {
                            var result = Regex.Match(line, "seta sv_fixedMapRotation \"(.*?)\"");
                            if (result.Success)
                                FixedMapRotation = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_maxclients"))
                        {
                            var result = Regex.Match(line, "seta sv_maxclients \"(.*?)\"");
                            if (result.Success)
                                MaxClients = result.Groups[1].Value;
                        }
                        else if (line.Contains("g_password"))
                        {
                            var result = Regex.Match(line, "seta g_password \"(.*?)\"");
                            if (result.Success)
                                Password = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_privateClients"))
                        {
                            var result = Regex.Match(line, "seta sv_privateClients \"(.*?)\"");
                            if (result.Success)
                                PrivateClients = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_privatePassword"))
                        {
                            var result = Regex.Match(line, "seta sv_privatePassword \"(.*?)\"");
                            if (result.Success)
                                PrivatePassword = result.Groups[1].Value;
                        }
                        else if (line.Contains("rcon_password"))
                        {
                            var result = Regex.Match(line, "seta rcon_password \"(.*?)\"");
                            if (result.Success)
                                RconPassword = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_voice"))
                        {
                            var result = Regex.Match(line, "seta sv_voice \"(.*?)\"");
                            if (result.Success)
                                Voice = result.Groups[1].Value;
                        }
                        else if (line.Contains("g_allowVote"))
                        {
                            var result = Regex.Match(line, "seta g_allowVote \"(.*?)\"");
                            if (result.Success)
                                AllowVote = result.Groups[1].Value;
                        }
                        else if (line.Contains("g_deadChat"))
                        {
                            var result = Regex.Match(line, "seta g_deadChat \"(.*?)\"");
                            if (result.Success)
                                DeadChat = result.Groups[1].Value;
                        }
                        else if (line.Contains("g_inactivity"))
                        {
                            var result = Regex.Match(line, "seta g_inactivity \"(.*?)\"");
                            if (result.Success)
                                Inactivity = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_kickBanTime"))
                        {
                            var result = Regex.Match(line, "seta sv_kickBanTime \"(.*?)\"");
                            if (result.Success)
                                TempBanTime = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_floodProtect"))
                        {
                            var result = Regex.Match(line, "seta sv_floodProtect \"(.*?)\"");
                            if (result.Success)
                                FloodProtect = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_maxping"))
                        {
                            var result = Regex.Match(line, "seta sv_maxping \"(.*?)\"");
                            if (result.Success)
                                MaxPing = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_clanWebsite"))
                        {
                            var result = Regex.Match(line, "seta sv_clanWebsite \"(.*?)\"");
                            if (result.Success)
                                ClanWebsite = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_Discord"))
                        {
                            var result = Regex.Match(line, "seta sv_Discord \"(.*?)\"");
                            if (result.Success)
                                Discord = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_serverFullMsg"))
                        {
                            var result = Regex.Match(line, "seta sv_serverFullMsg \"(.*?)\"");
                            if (result.Success)
                                ServerFullMessage = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_ban_by_guid"))
                        {
                            var result = Regex.Match(line, "seta sv_ban_by_guid \"(.*?)\"");
                            if (result.Success)
                                BanByGuid = result.Groups[1].Value;
                        }
                        else if (line.Contains("sv_ban_by_ip"))
                        {
                            var result = Regex.Match(line, "seta sv_ban_by_ip \"(.*?)\"");
                            if (result.Success)
                                BanByIp = result.Groups[1].Value;
                        }
                        else if (line.Contains("scr_teambalance"))
                        {
                            var result = Regex.Match(line, "seta scr_teambalance \"(.*?)\"");
                            if (result.Success)
                                TeamAutoBalance = result.Groups[1].Value;
                        }
                        else if (line.Contains("g_playerCollision"))
                        {
                            var result = Regex.Match(line, "seta g_playerCollision \"(.*?)\"");
                            if (result.Success)
                                PlayerCollision = result.Groups[1].Value;
                        }
                        else if (line.Contains("dedicated"))
                        {
                            var result = Regex.Match(line, "seta dedicated \"(.*?)\"");
                            if (result.Success)
                                SpecifyServerVisibility = result.Groups[1].Value;
                        }
                        else if (line.Contains("net_queryPort"))
                        {
                            var result = Regex.Match(line, "seta net_queryPort \"(.*?)\"");
                            if (result.Success)
                                OpenGamePort = result.Groups[1].Value;
                        }
                        else if (line.Contains("net_port"))
                        {
                            var result = Regex.Match(line, "seta net_port \"(.*?)\"");
                            if (result.Success)
                                SecureGamePort = result.Groups[1].Value;
                        }
                        else if (line.Contains("net_authPort"))
                        {
                            var result = Regex.Match(line, "seta net_authPort \"(.*?)\"");
                            if (result.Success)
                                AuthenticationPort = result.Groups[1].Value;
                        }
                        else if (line.Contains("net_masterServerPort"))
                        {
                            var result = Regex.Match(line, "seta net_masterServerPort \"(.*?)\"");
                            if (result.Success)
                                MasterServerPort = result.Groups[1].Value;
                        }
                    }
                }
            }
        }

        public void Write()
        {
            byte[] bytes = Properties.Resources.Server;
            string content = Encoding.UTF8.GetString(bytes);

            content = content.Replace("<sv_hostname>", HostName.Trim())
                .Replace("<sv_maprotation>", MapRotation.Trim())
                .Replace("<sv_fixedMapRotation>", FixedMapRotation.Trim())
                .Replace("<sv_maxclients>", MaxClients.Trim())
                .Replace("<g_password>", Password.Trim())
                .Replace("<sv_privateClients>", PrivateClients.Trim())
                .Replace("<sv_privatePassword>", PrivatePassword.Trim())
                .Replace("<rcon_password>", RconPassword.Trim())
                .Replace("<sv_voice>", Voice.Trim())
                .Replace("<g_allowVote>", AllowVote.Trim())
                .Replace("<g_deadChat>", DeadChat.Trim())
                .Replace("<g_inactivity>", Inactivity.Trim())
                .Replace("<sv_kickBanTime>", TempBanTime.Trim())
                .Replace("<sv_floodProtect>", FloodProtect.Trim())
                .Replace("<sv_maxping>", MaxPing.Trim())
                .Replace("<sv_clanWebsite>", ClanWebsite.Trim())
                .Replace("<sv_Discord>", Discord.Trim())
                .Replace("<sv_serverFullMsg>", ServerFullMessage.Trim())
                .Replace("<sv_ban_by_guid>", BanByGuid.Trim())
                .Replace("<sv_ban_by_ip>", BanByIp.Trim())
                .Replace("<dedicated>", SpecifyServerVisibility.Trim())
                .Replace("<net_queryPort>", OpenGamePort.Trim())
                .Replace("<net_port>", SecureGamePort.Trim())
                .Replace("<net_authPort>", AuthenticationPort.Trim())
                .Replace("<net_masterServerPort>", MasterServerPort.Trim())
                .Replace("<scr_teambalance>", TeamAutoBalance.Trim())
                .Replace("<g_playerCollision>", PlayerCollision.Trim());

            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write(content);
                if (scripts.Count > 0 && HasScripts)
                {
                    foreach (var line in scripts)
                        sw.WriteLine($"loadScript \"{line}\"");
                }
                else
                    sw.WriteLine("//loadScript \"MyScript.dll\"");

                if (commands.Count > 0 && HasCommands)
                {
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine("//Other Command");
                    foreach (var cmd in commands)
                    {
                        sw.WriteLine(cmd);
                    }
                    sw.WriteLine();
                }
                else
                    sw.WriteLine();
            }
            File.WriteAllText(_path, sb.ToString());
        }
    }
}
