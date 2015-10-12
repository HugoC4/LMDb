using System.Collections.Generic;

namespace LMDb.Db
{
    /**
    *   Episode object
    */
    class Episode : Content
    {
        public int EpisodeID { get; set; }
        public int? EpisodeIndex { get; set; }
        public virtual Season Season { get; set; } 
    }
}
