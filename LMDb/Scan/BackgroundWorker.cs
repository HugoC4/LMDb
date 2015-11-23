using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using LMDb.API.OpenSubtitles;
using LMDb.Properties;

namespace LMDb.Scan
{
    class BackgroundWorker : BackgroundWorkerHelper
    {
        public enum WorkerOperations
        {
            InitialScan,
            UpdateArtCache,
            SubtitleSearch,
            StartMovie
        }

        public static void InitialScan(MainForm form)
        {
            SelectTab(form, 0);

            ProgressState progress = new ProgressState();
            progress.SetText(Resources.Loading_Library_CheckChanges);
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            Thread.Sleep(1250);
            
            List<string> files = ScanLibrary();

            progress.IncrementValue(15).SetText(Resources.Loading_Library_Update_Database).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            CleanUpDatabase(files);

            Program.Context.SaveChanges();
            Thread.Sleep(1250);

            progress.IncrementValue(20).SetText(Resources.Loading_Library_RetrieveImdbInfo).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            UpdateImdbInformation(form, progress);

            Thread.Sleep(1250);

            progress.SetText(Resources.Loading_Library_Update_Cache).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            UpdateArtCache(Types.GetEnumByPosterWidth(Settings.Default.PosterSize), form, progress);
            Thread.Sleep(1250);

            progress.IncrementValue(15).SetText(Resources.Loading_Library_Prepare_Homepage).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);


            progress.SetSubText(Resources.Loading_Library_Prepare_Homepage_Folders);
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
            
            Program.CreateCacheFolders();
            Thread.Sleep(1250);

            UpdateGUI(form, progress);

            progress.SetValue(100).SetText(Resources.Loading_Library_Complete).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            Thread.Sleep(1250);

            form.Invoke(new Action(() => form.resizeTimer.Start()));
            SelectTab(form, 1);

            progress.ResetValue().EmptyText().EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
        }

        public static void ArtCacheUpdate(MainForm form)
        {
            SelectTab(form, 0);

            ProgressState progress = new ProgressState();
            progress.SetText(Resources.Loading_Library_Update_Cache);
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            form.Invoke(new Action(() => form.MovieCards.Values.ToList().ForEach(p => p.Image = Resources.poster_placeholder)));

            UpdateArtCache(Types.GetEnumByPosterWidth(Settings.Default.PosterSize), form, progress);
            Thread.Sleep(1250);

            progress.SetText(Resources.Loading_Library_Update_Cache_Complete).SetValue(50);
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
            Thread.Sleep(1250);

            progress.SetText(Resources.Loading_Library_Update_Cache_GUI);
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            UpdateGUI(form, progress);
            Thread.Sleep(1250);

            progress.SetText(Resources.Loading_Library_Update_Cache_GUI_Complete).SetValue(100);
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
            Thread.Sleep(1250);

            SelectTab(form, 1);
            progress.ResetValue().EmptyText().EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
        }

        public static void SubtitleSearch(MainForm form, string imdbId)
        {
            List<Subtitle> result = API.OpenSubtitles.OpenSubtitles.SearchSubtitlesByImdbId(imdbId);
            result.Sort((x, y) => x.language.CompareTo(y.language) == 0 ? y.downloaded.CompareTo(x.downloaded) : x.language.CompareTo(y.language));
            form.Invoke(new Action(() =>
            {
                form.mcSubs.Items.AddRange(result.ToArray());
                form.mcSubs.Enabled = true;
            }));
        }

        public static void StartMovie(MainForm form, string path, object sub) 
        {
            SelectTab(form, 0); ProgressState progress = new ProgressState();

            Subtitle subtitle = sub as Subtitle;
            if (subtitle != null)
            {
                progress.SetText("Downloading subtitles...");
                form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
                API.OpenSubtitles.OpenSubtitles.DownloadSubtitles(path.Remove(path.LastIndexOf(@"\")), subtitle);
            }

            progress.SetText("Starting movie...");
            Thread.Sleep(1250);
            System.Diagnostics.Process.Start(path);
            SelectTab(form, 2);
            progress.ResetValue().EmptyText().EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

        }

        public static void ProgressChanged(object sender, ProgressChangedEventArgs e, MainForm form)
        {
            form.ldHome.Value = e.ProgressPercentage;
            if (e.UserState is ProgressState)
            {
                ProgressState progress = (ProgressState)e.UserState;
                form.ldHome.Text = progress.Text;
                form.ldHome.SubText = progress.SubText;
            }
        }
    }
}
