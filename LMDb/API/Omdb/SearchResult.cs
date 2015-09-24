using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.API.Omdb
{
    public class SearchResult : ApiResult
    {
        public SearchEntry[] Search { get; set; }
    }
}
