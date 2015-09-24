using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.API.Omdb
{
    public class SearchEntry
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public Types.SearchType Type { get; set; }
    }
}
