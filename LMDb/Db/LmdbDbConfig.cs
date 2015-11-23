using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    class LmdbDbConfig : DbConfiguration
    {
        public LmdbDbConfig()
        {
            this.SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
        }
    }
}
