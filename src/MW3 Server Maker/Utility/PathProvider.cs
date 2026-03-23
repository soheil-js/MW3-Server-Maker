using System;
using System.IO;

namespace MW3_Server_Maker
{
    internal static class PathProvider
    {
        public static string MVSoftFolderPath { get; private set; }
        public static string Players2FolderPath { get; private set; }
        public static string LauncherFilePath { get; private set; }
        public static string CfgFilePath { get; private set; }
        public static string DsplFilePath { get; private set; }
        public static string SettingsFilePath { get; private set; }
        public static string ScriptsFilePath { get; private set; }
        public static string CommandsFilePath { get; private set; }

        static PathProvider()
        {
            MVSoftFolderPath = Path.Combine(Environment.CurrentDirectory, "mvsoft");
            Players2FolderPath = Path.Combine(Environment.CurrentDirectory, "players2");
            LauncherFilePath = Path.Combine(Environment.CurrentDirectory, "TeknoMW3_Server_Launcher.exe");
            CfgFilePath = Path.Combine(Players2FolderPath, "Server.cfg");
            DsplFilePath = Path.Combine(Players2FolderPath, "Default.dspl");
            SettingsFilePath = Path.Combine(MVSoftFolderPath, "Settings.mv");
            ScriptsFilePath = Path.Combine(MVSoftFolderPath, "Scripts.mv");
            CommandsFilePath = Path.Combine(MVSoftFolderPath, "Commands.mv");


            if (!Directory.Exists(MVSoftFolderPath))
                Directory.CreateDirectory(MVSoftFolderPath);

            if (!Directory.Exists(Players2FolderPath))
                Directory.CreateDirectory(Players2FolderPath);
        }
    }
}
