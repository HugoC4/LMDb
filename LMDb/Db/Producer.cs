﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    /**
    *   Series object
    */
    class Producer
    {
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
        public virtual List<Series> Series { get; set; }

    }
}