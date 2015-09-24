using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    /**
    *   Content object (Unidentified files)
    */

    internal class Content
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public Types.ItemStatus Status { get; set; }
        public virtual Rating Rating { get; set; }
        public DateTime? Released { get; set; }
        public string Runtime { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Director> Directors { get; set; }
        public virtual List<Writer> Writers { get; set; }
        public virtual List<Actor> Actors { get; set; }
        public string Plot { get; set; }
        public virtual List<Language> Languages { get; set; }
        public virtual List<Country> Countries { get; set; }
        public string Awards { get; set; }
        public virtual Art Poster { get; set; }

        public int? Metascore { get; set; }
        public float? ImdbRating { get; set; }
        public string ImdbId { get; set; }

        public int? TomatoMeter { get; set; }
        public Types.TomatoImages TomatoImage { get; set; }
        public float? TomatoRating { get; set; }
        public int? TomatoReviews { get; set; }
        public int? TomatoFresh { get; set; }
        public int? TomatoRotten { get; set; }
        public string TomatoConsensus { get; set; }
        public int? TomatoUserMeter { get; set; }
        public float? TomatoUserRating { get; set; }
        public int? TomatoUserReviews { get; set; }

        public DateTime? DvdRelease { get; set; }
        public string BoxOffice { get; set; }
        public virtual List<Producer> Producers { get; set; }
        public string Website { get; set; }
        
    }
}
