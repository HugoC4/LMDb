using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;
using Newtonsoft.Json;

namespace LMDb.API.Omdb
{
    public class InformationResult
    {
        public string Title { get; set; }

        [OmdbIgnoreNormalization]
        public int? Year { get; set; }

        [OmdbIgnoreNormalization]
        public string RawYear { get; set; }
        public int? Episode { get; set; }
        public int? Season { get; set; }
        public string Rated { get; set; }
        public DateTime? Released { get; set; }
        public string Runtime { get; set; }
        public List<string> Genre { get; set; }
        public List<string> Director { get; set; }
        public List<string> Writer { get; set; }
        public List<string> Actors { get; set; }
        public string Plot { get; set; }
        public List<string> Language { get; set; }
        public List<string> Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public int? Metascore { get; set; }
        public float? imdbRating { get; set; }
        public int? imdbVotes { get; set; }
        public string imdbID { get; set; }
        public Types.SearchType? Type { get; set; }

        public int? tomatoMeter { get; set; }
        public Types.TomatoImages? tomatoImage { get; set; }
        public float? tomatoRating { get; set; }
        public int? tomatoReviews { get; set; }
        public int? tomatoFresh { get; set; }
        public int? tomatoRotten { get; set; }
        public string tomatoConsensus { get; set; }
        public int? tomatoUserMeter { get; set; }
        public float? tomatoUserRating { get; set; }
        public int? tomatoUserReviews { get; set; }

        public DateTime? DVD { get; set; }
        public string BoxOffice { get; set; }
        public List<string> Production { get; set; }
        public string Website { get; set; }
    }
}
