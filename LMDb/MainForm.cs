using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using LMDb.API.Omdb;
using LMDb.Controls;
using LMDb.Db;
using LMDb.Properties;
using LMDb.Scan;
using LMDb.VideoNameParser;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using BackgroundWorker = LMDb.Scan.BackgroundWorker;
using ComboBox = System.Windows.Forms.ComboBox;

namespace LMDb
{
    public partial class MainForm :MetroForm
    {
        private int _height { get; set; }
        private int _heightDetail { get; set; }
        private int _colCount { get; set; }
        private Movie curMovie { get; set; }
        public Dictionary<string, PosterCard> MovieCards = new Dictionary<string, PosterCard>();

        public MainForm()
        {
            InitializeComponent();
            mtcMainTabs.SelectTab(0);
            mlDetailSynopsis.Font = MetroFonts.Label(MetroLabelSize.Medium, MetroLabelWeight.Light);
            mlDetailSynopsis.ForeColor = MetroPaint.ForeColor.Label.Normal(MetroStyleManager.Default.Theme);

            GetRadioButtonByTag(Settings.Default.PosterSize).Checked = true;

            int i = -1;
            foreach (MetroThemeStyle e in Types.GetEnumList<MetroThemeStyle>())
            {
                if (e.ToString().ToLower() != "default")
                {
                    mcTheme.Items.Add(e);
                    i++;
                    if (Settings.Default.Theme.Equals(e))
                    {
                        mcTheme.SelectedIndex = i;
                    }
                }
            }

            i = -1;
            foreach (MetroColorStyle e in Types.GetEnumList<MetroColorStyle>())
            {
                if (e.ToString().ToLower() != "default")
                {
                    mcStyle.Items.Add(e);
                    i++;
                    if (Settings.Default.Style.Equals(e))
                    {
                        mcStyle.SelectedIndex = i;
                    }
                }
            }

            tlOverview.ColumnStyles.RemoveAt(0);
            tlOverview.ColumnCount = 0;

            Settings.Default.SearchableExtensions = Settings.Default.SearchableExtensions ?? new StringCollection();
            if (Settings.Default.SearchableExtensions.Count == 0)
            {
                Settings.Default.SearchableExtensions.AddRange(Types.GetEnumStrings<Types.Extensions>().ToArray());
                Settings.Default.Save();
            }

            scanningBackgroundWorker.RunWorkerAsync(Scan.BackgroundWorker.WorkerOperations.InitialScan);
            
        }

        private void resizeTimer_Tick(object sender, EventArgs e)
        {
            if (_height != tlOverview.Height || _colCount != tlOverview.ColumnStyles.Count)
            {
                _colCount = tlOverview.ColumnStyles.Count;
                _height = tlOverview.Height;
                int posterCount = tlOverview.Controls.OfType<PosterCard>().Count();
                int width = (int)Math.Round((((tlOverview.Height - 10) * (0.675)) * posterCount) + (posterCount * 10));
                tlOverview.Width = width;
            }
            if (_heightDetail != tlpDetails.Height)
            {
                _heightDetail = tlpDetails.Height;
                tlpDetails.ColumnStyles[1].Width = _heightDetail * (0.675F);
            }
        }

        private void scanningBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new Action(() => ToggleResolutionOptions(false)));
            Scan.BackgroundWorker.WorkerOperations operation;
            if (Enum.TryParse(e.Argument.ToString(), out operation))
            {
                switch (operation)
                {
                    case BackgroundWorker.WorkerOperations.InitialScan:
                        Scan.BackgroundWorker.InitialScan(this);
                        break;
                    case BackgroundWorker.WorkerOperations.UpdateArtCache:
                        Scan.BackgroundWorker.ArtCacheUpdate(this);
                        break;

                }
            } // Kinda dirty, sorry
            else
            {
                object[] args = e.Argument as object[];
                if (Enum.TryParse(args[0]?.ToString(), out operation))
                {
                    switch (operation)
                    {
                         case BackgroundWorker.WorkerOperations.SubtitleSearch:
                                Scan.BackgroundWorker.SubtitleSearch(this, args[1].ToString());
                            
                            break;
                        case BackgroundWorker.WorkerOperations.StartMovie:
                            Scan.BackgroundWorker.StartMovie(this, args[1].ToString(), args[2]);
                            break;
                    }
                } else { } // Woopsy
            }
            this.Invoke(new Action(() => ToggleResolutionOptions(true)));
        }

        private void scanningBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Scan.BackgroundWorker.ProgressChanged(sender, e, this);
        }

        private void NavigationClicked(object sender, EventArgs e)
        {
            MetroLink label = sender as MetroLink;
            if (label != null)
            {
                int val;
                if (label.Tag != null && int.TryParse(label.Tag.ToString(), out val))
                {
                    vcSettings.SelectTab(val);
                }
            }
        }

        private void mcTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var theme = mcTheme.SelectedItem;
            if (theme is MetroThemeStyle)
            {
                MetroStyleManager.Default.Theme = (MetroThemeStyle) theme;
                Settings.Default.Theme = (MetroThemeStyle) theme;
                Settings.Default.Save();
            }
        }

        private void mcStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var style = mcStyle.SelectedItem;
            if (style is MetroColorStyle)
            {
                MetroStyleManager.Default.Style = (MetroColorStyle) style;
                Settings.Default.Style = (MetroColorStyle) style;
                Settings.Default.Save();
            }
        }

        private void mbChangeImage_Click(object sender, EventArgs e)
        {

        }

        private void mrbPoster_CheckedChanged(object sender, EventArgs e)
        {
            MetroRadioButton button = sender as MetroRadioButton;
            if (button != null)
            {
                int width = int.Parse(button.Tag.ToString());
                if (button.Checked && Settings.Default.PosterSize != width)
                {
                    Settings.Default.PosterSize = width;
                    Settings.Default.Save();
                    scanningBackgroundWorker.RunWorkerAsync(Scan.BackgroundWorker.WorkerOperations.UpdateArtCache);
                }
            }
        }

        private MetroRadioButton GetRadioButtonByTag(int tag)
        {
            switch (Types.GetEnumByPosterWidth(tag))
            {
                case Types.PosterWidth.HQ:
                    return mrbPoster480;
                case Types.PosterWidth.HD:
                    return mrbPoster720;
                case Types.PosterWidth.FullHD:
                    return mrbPoster1080;
                default:
                    return mrbPosterDefault;
            }
        }

        private void ToggleResolutionOptions(bool state)
        {
            mrbPosterDefault.Enabled = state;
            mrbPoster480.Enabled = state;
            mrbPoster720.Enabled = state;
            mrbPoster1080.Enabled = state;
        }

        public void Poster_click(PosterCard sender, EventArgs e)
        {
            Movie m = sender.Movie;
            curMovie = m;
            mlDetailsTitle.Text = m.Title + (m.Year.HasValue ? $" ({m.Year.Value})" : "");
            mlDetailSynopsis.Text = m.Plot;
            pbDetails.Image = sender.Image;
            mlReleased.Text = m.Released != null ? "Released: " + m.Released.Value.ToString(Program.DateFormat) : "";
            mlRuntime.Text = m.Runtime;
            mlImdbRating.Text = m.Rating?.Name;
            string s = "";
            ((List<Actor>)m.Actors).ForEach((a) => s += a.Name + ", ");
            s = s.TrimEnd(", ".ToCharArray());
            mlActors.Text = s == "" ? "" : "Actors: " + s;
            s = "";
            ((List<Writer>)m.Writers).ForEach((a) => s += a.Name + ", ");
            s = s.TrimEnd(", ".ToCharArray());
            mlWriters.Text = s == "" ? "" : "Writers: " + s;
            s = "";
            ((List<Director>)m.Directors).ForEach((a) => s += a.Name + ", ");
            s = s.TrimEnd(", ".ToCharArray());
            mlDirectors.Text = s == "" ? "" : "Directors: " + s;
            mlWebsite.Text = m.Website != "" ? "Website: " + m.Website : "";
            mcPaths.Items.Clear();
            mcPaths.Items.AddRange(m.Paths.ToArray());
            mcPaths.SelectedIndex = 0;
            mcSubs.Items.Clear();
            mcSubs.Items.Add("<No subtitles>");
            mcSubs.SelectedIndex = 0;
            mcSubs.Enabled = false;
            vcHome.SelectTab(2);
            scanningBackgroundWorker.RunWorkerAsync(new object[] { BackgroundWorker.WorkerOperations.SubtitleSearch, m.ImdbId});
        }

        public void Poster_click(object sender, EventArgs e) => Poster_click(sender as PosterCard, e);
        

        private void mbWatch_Click_1(object sender, EventArgs e)
        {
            scanningBackgroundWorker.RunWorkerAsync(new object[] { BackgroundWorker.WorkerOperations.StartMovie, (mcPaths.SelectedItem as ContentPath).Path, mcSubs.SelectedItem});
        }

        private void mbBack_Click(object sender, EventArgs e)
        {
            vcHome.SelectTab(1);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
