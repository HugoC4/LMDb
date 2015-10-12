using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using LMDb.API.Omdb;

namespace LMDb.Db
{
    /**
    *   Movie object
    */
    class Movie : Content
    {
        public int MovieID { get; set; }

        public Movie()
        {
            SearchResult = new SearchResult {Search = null};
        }

        public SearchResult SearchResult { get; set; }

        public bool ParseApiResults(InformationResult infoRes)
        {
            this.Title = infoRes.Title ?? this.Title;
            this.Year = infoRes.Year ?? this.Year;

            this.Released = infoRes.Released ?? this.Released;
            this.Runtime = infoRes.Runtime ?? this.Runtime;
            this.Plot = infoRes.Plot ?? this.Plot;
            this.Awards = infoRes.Awards ?? this.Awards;
            this.Metascore = infoRes.Metascore ?? this.Metascore;
            this.ImdbRating = infoRes.imdbRating ?? this.ImdbRating;
            this.ImdbId = infoRes.imdbID ?? this.ImdbId;

            this.TomatoMeter = infoRes.tomatoMeter ?? this.TomatoMeter;
            this.TomatoImage = infoRes.tomatoImage ?? this.TomatoImage;
            this.TomatoRating = infoRes.tomatoRating ?? this.TomatoRating;
            this.TomatoReviews = infoRes.tomatoReviews ?? this.TomatoReviews;
            this.TomatoFresh = infoRes.tomatoFresh ?? this.TomatoFresh;
            this.TomatoRotten = infoRes.tomatoRotten ?? this.TomatoRotten;
            this.TomatoConsensus = infoRes.tomatoConsensus ?? this.TomatoConsensus;
            this.TomatoUserMeter = infoRes.tomatoUserMeter ?? this.TomatoUserMeter;
            this.TomatoUserRating = infoRes.tomatoUserRating ?? this.TomatoUserRating;
            this.TomatoUserReviews = infoRes.tomatoUserReviews ?? this.TomatoUserReviews;

            this.DvdRelease = infoRes.DVD ?? this.DvdRelease;
            this.BoxOffice = infoRes.BoxOffice ?? this.BoxOffice;
            this.Website = infoRes.Website ?? this.Website;
            this.Actors = UpdateField<Actor>(infoRes.Actors);
            this.Writers = UpdateField<Writer>(infoRes.Writer);
            this.Languages = UpdateField<Language>(infoRes.Language);
            this.Countries = UpdateField<Country>(infoRes.Country);
            this.Producers = UpdateField<Producer>(infoRes.Production);
            this.Directors = UpdateField<Director>(infoRes.Director);
            this.Genres = UpdateField<Genre>(infoRes.Genre);
            this.Rating = UpdateField<Rating>(infoRes.Rated);
            
            if (!String.IsNullOrWhiteSpace(infoRes.Poster))
            {
                if (!Program.Context.Art.Any(p => p.WebPath == infoRes.Poster))
                {

                    Art poster = new Art {WebPath = infoRes.Poster};
                    Program.Context.Art.Add(poster);
                    this.Art = poster;
                }
                else
                {
                    this.Art = Program.Context.Art.Single(p => p.WebPath == infoRes.Poster);
                }
            }
            return true;
        }

        private T UpdateField<T>(string value) where T : class, IContentLink
        {
            DbSet<T> set = Program.Context.Set<T>();

            if (String.IsNullOrWhiteSpace(value))
                return null;

            T t;
            var aaaaaaa = set.ToList();
            if (set.Any(p => p.Name.Equals(value, StringComparison.OrdinalIgnoreCase)))
            {
                t = set.Single(p => p.Name.Equals(value, StringComparison.OrdinalIgnoreCase));
                t.Movies.Add(this);
                return t;
            }

            t = Activator.CreateInstance<T>();
            if (t == null) return null;
            t.Movies = new List<Movie> {this};
            t.Name = value;
            set.Add(t);

            return t;
            
        }

        private List<T> UpdateField<T>(List<string> values) where T : class, IContentLink
        {
            if (values == null) return null;
            if(values.Count == 0) return new List<T>();
            List<T> result = values.Select(UpdateField<T>).ToList();
            result.RemoveAll(p => p == null);
            
            return result;
        }
    }
}
