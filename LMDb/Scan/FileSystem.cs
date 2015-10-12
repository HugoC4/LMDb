using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMDb.Properties;

namespace LMDb.Scan
{
    class FileSystem
    {
        public static IEnumerable<string> GetFileTree(string directory)
        {
            foreach (string ext in Settings.Default.SearchableExtensions)
            {
                foreach (string s in GetFiles(directory, "*" + ext.ToLower()))
                {
                    yield return s;
                }
                
            }

            foreach (string s in GetDirectories(directory))
            {
                foreach (string f in GetFileTree(s))
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

        public static IEnumerable<string> GetFileTrees(string[] directories)
        {
            foreach (string path in directories)
            {
                foreach (string file in GetFileTree(path))
                    yield return file;
            }


        }
    }
}
