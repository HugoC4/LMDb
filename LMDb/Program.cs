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
            MetroStyleManager.Default.Theme = MetroThemeStyle.Dark;
            MetroStyleManager.Default.Style = MetroColorStyle.Purple;
            Application.Run(new MainForm());
        }
    }
}
