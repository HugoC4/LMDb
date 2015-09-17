using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;

namespace LMDb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MetroStyleManager.Default.Theme = Properties.Settings.Default.Theme;
            MetroStyleManager.Default.Style = Properties.Settings.Default.Style;
            Application.Run(new MainForm());
        }
    }
}
