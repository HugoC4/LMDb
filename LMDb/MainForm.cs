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
using System.Windows.Forms;
using LMDb.API.Omdb;
using LMDb.Controls;
using LMDb.Db;
using LMDb.Properties;
using LMDb.VideoNameParser;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace LMDb
{
    public partial class MainForm :MetroForm
    {
        private int _height { get; set; }
        private int _colCount { get; set; }

        public MainForm()
        {
            InitializeComponent();
            mtcMainTabs.SelectTab(0);

            switch (Settings.Default.PosterSize)
            {
                case 0:
                    break;
                case 720:
                    break;
                case 480:
                    break;
                case 1080:
                    break;
            }

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

            scanningBackgroundWorker.RunWorkerAsync();
            resizeTimer.Start();
            
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
        }

        private void scanningBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Scan.BackgroundWorker.DoWork(sender, e, this);
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
    }
}
