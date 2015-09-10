using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMDb.Properties;
using MetroFramework.Controls;

namespace LMDb
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        private Thread scanThread;
        private int _height { get; set; }
        private int _colCount { get; set; }

        private string[] extensions = new string[]
        {
            "mkv", "avi", "mov", "wmv",
            "mp4", "m4p", "m4v", "mpg",
            "mpeg", "m2v", "m4v"
        };

        public MainForm()
        {
            InitializeComponent();
            tlOverview.ColumnStyles.RemoveAt(0);
            tlOverview.ColumnCount = 0;
            resizeTimer.Start();
        }

        private List<string> GetFiles(string directory)
        {
            List<string> dirRes = new List<string>();

            foreach (string ext in this.extensions)
            {
                try
                {
                    foreach (string s in Directory.GetFiles(directory, "*" + ext))
                    {
                        string filename = s.Substring(s.LastIndexOf('\\') + 1);
                        ldHome.SubText = "(" + filename + ")";
                        dirRes.Add(filename);
                    }
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        
            

            try
            {
                foreach (string s in Directory.GetDirectories(directory))
                {
                    ldHome.SubText = "(" + s + ")";
                    dirRes.AddRange(GetFiles(s));
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            return dirRes;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            vcHome.SelectTab(0);
            scanThread = new Thread(() =>
            {
                this.Invoke(new Action(() =>
                {
                    ldHome.Text = Resources.Loading_Library_CheckChanges;
                }));
                List<string> files = GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                Thread.Sleep(1250);
                this.Invoke(new Action(() =>
                {
                    ldHome.Value = 25;
                    ldHome.Text = Resources.Loading_Library_Update_Database;
                    ldHome.SubText = "";
                }));
                Thread.Sleep(1250);
                this.Invoke(new Action(() =>
                {
                    ldHome.Value = 50;
                    ldHome.Text = Resources.Loading_Library_Prepare_Homepage;
                    ldHome.SubText = "";
                }));
                Thread.Sleep(1250);
                int i = 0;
                //files = files.GetRange(0, 24);
                float perc = 100 / (float)files.Count;
                int percPerFile = (int) Math.Floor(((float) files.Count/50F)*100);
                foreach (string file in files)
                {
                    this.Invoke(new Action(()  =>
                    {
                        ldHome.SubText = "(" + i + "/" + files.Count + " - " + file + ")";
                        PosterCard pc = new PosterCard();
                        pc.Text = file;
                        int val = (int)((i/(float)files.Count)*255);
                        
                        pc.Dock = DockStyle.Fill;
                        tlOverview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, perc));
                        tlOverview.Controls.Add(pc, i, 0);
                        ldHome.Value += percPerFile;
                    }));
                    i++;
                }
                this.Invoke(new Action(() =>
                {
                    ldHome.Text = Resources.Loading_Library_Complete;
                    ldHome.SubText = "";
                    ldHome.Value = 100;
                }));
                    Thread.Sleep(1250);
                this.Invoke(new Action(() =>
                {
                    vcHome.SelectTab(1);
                    ldHome.Dispose();
                }));
            });
            scanThread.Start();
        }

        private void resizeTimer_Tick(object sender, EventArgs e)
        {
            if (_height != tlOverview.Height || _colCount != tlOverview.ColumnStyles.Count)
            {
                _colCount = tlOverview.ColumnStyles.Count;
                _height = tlOverview.Height;
                int posterCount = tlOverview.Controls.OfType<PosterCard>().Count();
                int width = (int)Math.Round((((tlOverview.Height - 10) * (27F / 40F)) * posterCount) + (posterCount * 10));
                tlOverview.Width = width;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            scanThread.Abort();
            
        }
    }
}
