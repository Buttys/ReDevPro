using System;
using System.Windows.Forms;

namespace ReDevPro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config.Load(args);
            Application.Run(new MainForm());
        }
    }
}
