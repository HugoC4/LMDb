using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMDb.API.Omdb;
using LMDb.Controls;
using LMDb.Db;
using LMDb.Properties;
using LMDb.VideoNameParser;

namespace LMDb.Scan
{
    public class BackgroundWorkerHelper
    {
        protected static List<string> ScanLibrary()
        {
            var files = new List<string>();
            foreach (string file in FileSystem.GetFileTrees(Settings.Default.SearchPaths.Split(';')))
            {
                files.Add(file);
                string safeName = file.Substring(file.LastIndexOf(@"\") + 1);
                InformationGuess guess = Parser.ParseName(safeName, file);
                if (!guess.IsEpisode)
                {
                    if (!Program.Context.Movies.Any(p => p.Paths.Count(m => m.Path == file) == 1))
                    {
                        Movie movie = new Movie();
                        movie.Paths.Add((ContentPath)guess);
                        movie.Title = !String.IsNullOrWhiteSpace(guess.Title) ? guess.Title : safeName;
                        movie.Year = guess.Year != 0 ? (int?)guess.Year : null;
                        movie.Status = Types.ItemStatus.Unsynced;
                        Program.Context.Movies.Add(movie);
                    }
                }
            }
            return files;
        }

        protected static void CleanUpDatabase(List<string> files)
        {
            foreach (var cm in Program.Context.Movies.Include(p => p.Paths))
            {
                foreach (var c in cm.Paths.Where(c => !files.Contains(c.Path)))
                {
                    cm.Paths.Remove(c);
                }
                if (!cm.Paths.Any())
                    cm.Status = Types.ItemStatus.Deleted;
            }
        }

        protected static void SelectTab(MainForm form, int index)
        {
            form.Invoke(new Action(() =>
            {
                form.vcHome.SelectTab(index);
            }));
        }

        protected static void UpdateImdbInformation(MainForm form, ProgressState progress)
        {
            int i = 1;
            int count = Program.Context.Movies.Count(p => p.Status == Types.ItemStatus.Unsynced);
            foreach (Movie movie in Program.Context.Movies.Where(p => p.Status == Types.ItemStatus.Unsynced).ToArray())
            {
                progress.SetSubText(("(" + (i++) + "/" + count + ") " + movie.Title));
                form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

                SearchResult searchRes = Omdb.Search(movie.Title, movie.Year, Types.SearchType.Movie);
                if (searchRes != null && (!searchRes.Response.HasValue || searchRes.Response.Value))
                {
                    movie.SearchResult = searchRes;

                    if (searchRes.Search.Length == 0)
                    {
                        movie.Status = Types.ItemStatus.Ignored;
                    }
                    else if (searchRes.Search.Length == 1 || searchRes.Search.Any(p => p.Title.Equals(movie.Title, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        if (searchRes.Search.Count(p => p.Title.Equals(movie.Title, StringComparison.InvariantCultureIgnoreCase)) > 1)
                        {
                            movie.Status = Types.ItemStatus.Conflicted;
                            continue;
                        }

                        SearchEntry searchEntry = searchRes.Search.Length == 1 ? searchRes.Search.First() : searchRes.Search.Single(p => p.Title.Equals(movie.Title, StringComparison.InvariantCultureIgnoreCase));
                        InformationResult infoRes = !string.IsNullOrWhiteSpace(searchEntry.imdbID)
                            ? Omdb.GetInformationByImdbId(searchEntry.imdbID, null, Types.SearchType.Movie, false, true)
                            : Omdb.GetInformationByTitle(searchEntry.Title, movie.Year, Types.SearchType.Movie, false, true);

                        if (infoRes != null)
                        {
                            if (Program.Context.Movies.Any(p => p.ImdbId == infoRes.imdbID))
                            {
                                Movie m = Program.Context.Movies.Include(p => p.Paths).Single(p => p.ImdbId == infoRes.imdbID);
                                m.Paths.Add(movie.Paths.First());
                                Program.Context.Movies.Remove(movie);
                            }
                            else
                            {
                                movie.ParseApiResults(infoRes);
                                movie.Status = Types.ItemStatus.Synced;
                            }
                        }
                    }
                    else
                    {
                        movie.Status = Types.ItemStatus.Conflicted;
                    }
                }
                Program.Context.SaveChanges();
            }
            Program.Context.SaveChanges();
        }

        public static void UpdateArtCache(Types.PosterWidth pWidth, MainForm form, ProgressState progress)
        {
            int width = Types.GetPosterWidthByEnum(pWidth);
            int i = 0;
            int count = Program.Context.Movies.Count(p => p.Status == Types.ItemStatus.Synced);
            foreach (Movie file in Program.Context.Movies.Include(p => p.Art).Where(p => p.Status == Types.ItemStatus.Synced))
            {
                progress.SetSubText("(" + ((++i) + 1) + "/" + count + ") " + file.Title);
                form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);
                if (file.Art?.WebPath != null && (file.Art.CachePath == null || !File.Exists(file.Art.CachePath) || file.Art.Quality != pWidth))
                {
                    if (File.Exists(file.Art.CachePath))
                    {
                        File.Delete(file.Art.CachePath);
                    }
                    using (WebClient webClient = new WebClient())
                    {
                        file.Art.Quality = pWidth;
                        try
                        {
                            string url = Program.ImageCacheUrl + @"\" + file.Art.WebPath.GetHashCode() + ".jpg";
                            webClient.DownloadFile(file.Art.WebPath.Replace("V1_SX300.jpg", $"V1_SX{width}.jpg"), url);
                            file.Art.CachePath = url;
                        }
                        catch (Exception)
                        {
                            file.Art.CachePath = null;
                        }
                    }
                }
            }
            Program.Context.SaveChanges();
        }

        public static void UpdateGUI(MainForm form, ProgressState progress = null)
        {
            int i = 0;
            int count = Program.Context.Movies.Distinct().Count();
            float perc = 100 / (float)count;
            foreach (Movie file in Program.Context.Movies.Where(p => p.Status == Types.ItemStatus.Synced).OrderBy(p => p.Title).Include(p => p.Art).Include(p => p.Genres))
            {
                progress.SetSubText("(" + (i+1) + "/" + Program.Context.Movies.Count() + ") " + file.Title);
                form.scanningBackgroundWorker.ReportProgress(progress.Value, progress);

                form.Invoke(new Action(() =>
                {

                    PosterCard pc = form.MovieCards.ContainsKey(file.ImdbId) ? form.MovieCards[file.ImdbId] : new PosterCard();
                    
                    pc.Title = file.Title + (file.Year.HasValue ? $" ({file.Year.Value})" : "");
                    pc.Synopsis = file.Plot;
                    pc.Genres = "Genres: " + string.Join(", ", file.Genres.Select(p => p.Name));
                    pc.Rating = "Rating: " + (file.Rating?.Name);
                    
                    if (!string.IsNullOrWhiteSpace(file.Art?.CachePath))
                        pc.Image = Bitmap.FromFile(file.Art.CachePath);

                    if (!form.MovieCards.ContainsKey(file.ImdbId))
                    {
                        pc.Dock = DockStyle.Fill;
                        form.tlOverview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, perc));
                        form.tlOverview.Controls.Add(pc, i++, 0);
                        form.MovieCards.Add(file.ImdbId, pc);
                    }
                    pc.Movie = file;
                    pc.CustomClick += form.Poster_click;
                }));
            }
        }
    }
}
