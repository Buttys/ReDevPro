using System;
using System.Windows.Forms;

namespace ReDevPro
{
    static class Program
    {
        public static Random Random;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Random = new Random();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config.Load(args);
            Application.Run(new MainForm());
        }
    }
}
