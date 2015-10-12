using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    interface IContentLink
    {
        string Name { get; set; }
        ICollection<Movie> Movies { get; set; }
        ICollection<Series> Series { get; set; }
        ICollection<Episode> Episodes { get; set; }
    }
}
