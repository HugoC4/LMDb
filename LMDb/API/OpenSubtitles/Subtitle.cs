using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.API.OpenSubtitles
{
    class Subtitle
    {
        public string id { get; set; }
        public string language { get; set; }
        public string uploaded { get; set; }
        public long downloaded { get; set; }
        public string uploader { get; set; }

        public override string ToString()
        {
            string s = language + " - ";
            if (!String.IsNullOrWhiteSpace(uploader))
                s += uploader + " - ";
            s += downloaded + "x ";
            s += "(" + uploaded + ")";
            return s;
        }
    }
}
