using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMDb.VideoNameParser;

namespace LMDb.Db
{
    public class ContentPath
    {
        public int ContentPathID { get; set; }
        public string Path { get; set; }
        public string Codec { get; set; }
        public bool Extended { get; set; }
        public string Quality { get; set; }
        public string Resolution { get; set; }
        public Types.ItemStatus Status { get; set; }

        public static explicit operator ContentPath(InformationGuess guess)
        {
            if (guess == null) throw new NullReferenceException();
            return new ContentPath
            {
                Path = guess.Path,
                Codec = guess.Codec,
                Extended = guess.Extended,
                Quality = guess.Quality,
                Resolution = guess.Resolution
            };
        }

        public override string ToString()
        {
            return ((Resolution ?? Quality ?? Codec) + " " + (Extended ? "EXTENDED" : "")).Trim(' ') + " " + Path;
        }
    }
}
