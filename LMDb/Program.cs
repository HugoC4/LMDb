using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public static LmdbContext Context;
       
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

            //Database.SetInitializer(new DropCreateDatabaseAlways<LmdbContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LmdbContext, Configuration>());
            Context = new LmdbContext();
            //Context.Database.Delete();

           // using (var writer = new XmlTextWriter(@"D:\Model.edmx", Encoding.Default))
           // {
           //     EdmxWriter.WriteEdmx(Context, writer);
           // }

            //int total = Context.Movies.Count();
            //int found = 0;
            //List<InformationResult> a = new List<InformationResult>();
            //foreach (Movie movie in Context.Movies)
            //{
                //SearchResult b = Omdb.Search(movie.Title, movie.Year);
                //if (b != null)
                //{
                    //found++;
                    //var c = Omdb.GetInformationByTitle(movie.Title, null, Types.SearchType.Episode, false, true, 1, 1);
                    //if(c != null)
                        //a.Add(c);
                //}
            //}

            //Console.WriteLine("Fount: " + found + "/" + total);
            //while (true) continue;
            Application.Run(new MainForm());

        }
    }
}
