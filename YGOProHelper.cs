using System.Diagnostics;
using System.Windows.Forms;

namespace ReDevPro
{
    public static class YGOProHelper
    {
        private static void Open(string args = "")
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(Config.GetString("YGOProEXE","ygopro.exe"), args)
                {
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                process.StartInfo = startInfo;
                process.EnableRaisingEvents = true;
                process.Start();
            }
            catch
            {
                MessageBox.Show("Unable to find YGOPro", "Missing File");
            }
        }

        public static void OpenDeckEdit()
        {
            Open("-d");
        }

        public static void OpenOffline()
        {
            Open();
        }

        public static void OpenReplays()
        {
            Open("-r");
        }

        public static void OpenSingle()
        {
            Open("-s");
        }

        public static void OpenAI()
        {
            Open("-ai");
        }

        public static void OpenDuel()
        {
            Config.SaveConfig();
            Open("-c");
        }
    }
}
