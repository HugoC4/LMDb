using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using LMDb.Properties;

namespace LMDb.Scan
{
    class BackgroundWorker : BackgroundWorkerHelper
    {
        
        public static void DoWork(object sender, DoWorkEventArgs e, MainForm form)
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

            progress.IncrementValue(15).SetText(Resources.Loading_Library_Prepare_Homepage).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            Thread.Sleep(1250);

            Program.CreateCacheFolders();

            UpdateArtCache();

            UpdateGUI(form, progress);

            progress.SetValue(100).SetText(Resources.Loading_Library_Complete).EmptySubText();
            form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

            Thread.Sleep(1250);

            SelectTab(form, 1);

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
