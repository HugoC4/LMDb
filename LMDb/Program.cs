using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using LMDb.API.Omdb;
using LMDb.Db;
using LMDb.Migrations;
using MetroFramework;
using MetroFramework.Components;

namespace LMDb
{
    static class Program
    {
        public static LmdbContext Context { get; set; }
        public static string BaseUrl = AppDomain.CurrentDomain.BaseDirectory;
        public static string CacheUrl = BaseUrl + @"\cache";
        public static string ImageCacheUrl = CacheUrl + @"\img";
        public static string DateFormat = "dd-mm-YYYY";

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
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LmdbContext, Configuration>());
            Context = new LmdbContext();
            //Context.Database.Delete();

            CreateCacheFolders();
            Application.Run(new MainForm());
        }

        public static void CreateCacheFolders()
        {
            if (!Directory.Exists(BaseUrl))
                Directory.CreateDirectory(BaseUrl);

            if (!Directory.Exists(CacheUrl))
                Directory.CreateDirectory(CacheUrl);

            if (!Directory.Exists(ImageCacheUrl))
                Directory.CreateDirectory(ImageCacheUrl);
        }
    }
}
