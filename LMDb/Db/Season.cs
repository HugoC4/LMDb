using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    /**
    *   Episode object
    */
    class Season
    {
        public int SeasonId { get; set; }
        public virtual List<Episode>  Episodes { get; set; }
    }
}
