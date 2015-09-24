using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    /**
    *   Series object
    */
    class Series : Content
    {
        public int SeriesId { get; set; }
        public virtual List<Season> Seasons { get; set; }
    }
}
