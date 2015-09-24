using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMDb.Properties;

namespace LMDb
{
    class FileSystem
    {
        public static IEnumerable<string> GetFileTree(string directory, BackgroundWorker worker = null, ProgressState progress = null)
        {
            bool report = worker != null && progress != null;

            foreach (string ext in Settings.Default.SearchableExtensions)
            {
                foreach (string s in GetFiles(directory, "*" + ext.ToLower()))
                {
                    string filename = s.Substring(s.LastIndexOf('\\') + 1);
                    if (report)
                    {
                        progress.SetSubText("(" + filename + ")");
                        worker.ReportProgress(progress.Value, progress);
                    }
                    yield return s;
                }
                
            }

            foreach (string s in GetDirectories(directory))
            {
                if (report)
                {
                    progress.SetSubText("(" + s + ")");
                    worker.ReportProgress(progress.Value, progress);
                }
                foreach (string f in GetFileTree(s, worker, progress))
                {
                    yield return f;
                }
            }
        }

        public static string[] GetFiles(string directory, string filter = "*")
        {
            try
            {
                return Directory.GetFiles(directory, filter);
            }
            catch (Exception)
            {
                return new string[0];
            }
        }

        public static string[] GetDirectories(string directory, string filter = "*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            try
            {
                return Directory.GetDirectories(directory, filter, searchOption);
            }
            catch (Exception)
            {
                return new string[0];
            }
        }

        public static IEnumerable<string> GetFileTrees(string[] directories, BackgroundWorker worker = null, ProgressState progress = null)
        {
            foreach (string path in directories)
            {
                foreach (string file in GetFileTree(path, worker, progress))
                    yield return file;
            }


        }
    }
}
