using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMDb.API.Omdb;

namespace LMDb.Db
{
    /**
    *   Series object
    */
    class Series : Content
    {
        public Series()
        {
            Seasons = new List<Season>();
        }
        public int SeriesID { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
        public SearchResult SearchResult { get; set; }
    }
}
