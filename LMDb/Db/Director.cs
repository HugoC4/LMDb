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

    public class Director : IContentLink
    {
        public Director()
        {
            Movies = new List<Movie>();
            Series = new List<Series>();
            Episodes = new List<Episode>();
        }
        public int DirectorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Series> Series { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
    }
}
