using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    /**
    *   Art object
    */

    public class Art
    {
        public int ArtID { get; set; }
        public string WebPath { get; set; }
        public string CachePath { get; set; }
        public Types.PosterWidth Quality { get; set; }
    }
}
