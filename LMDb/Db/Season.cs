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

    public class Season
    {
        public Season()
        {
            Episodes = new List<Episode>();
        }

        public int SeasonID { get; set; }
        public int? SeasonIndex { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual Series Series { get; set; }
    }
}
