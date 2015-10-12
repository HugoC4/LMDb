using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb.Db
{
    class LmdbContext : DbContext
    {
        public DbSet<Art> Art { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Episode> Episode { get; set; }

        public LmdbContext()
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasMany(m => m.Actors).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasMany(m => m.Countries).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasMany(m => m.Directors).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasMany(m => m.Genres).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasMany(m => m.Languages).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasMany(m => m.Producers).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasMany(m => m.Writers).WithMany(o => o.Movies);
            modelBuilder.Entity<Movie>().HasOptional(m => m.Art);

            modelBuilder.Entity<Series>().HasMany(m => m.Actors).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Countries).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Directors).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Genres).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Languages).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Producers).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Writers).WithMany(o => o.Series);
            modelBuilder.Entity<Series>().HasMany(m => m.Seasons).WithRequired(o => o.Series);
            modelBuilder.Entity<Series>().HasOptional(m => m.Art);

            modelBuilder.Entity<Episode>().HasMany(m => m.Actors).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasMany(m => m.Countries).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasMany(m => m.Directors).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasMany(m => m.Genres).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasMany(m => m.Languages).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasMany(m => m.Producers).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasMany(m => m.Writers).WithMany(o => o.Episodes);
            modelBuilder.Entity<Episode>().HasOptional(m => m.Art);

            modelBuilder.Entity<Season>().HasMany(s => s.Episodes).WithOptional(e => e.Season);
            
            // TODO: Check this!
            //modelBuilder.Entity<Episode>().HasOptional(m => m.Season);
            //modelBuilder.Entity<Episode>().HasOptional(m => m.Series);
            /*
            // TODO: Check this!
            modelBuilder.Entity<Season>().HasMany(m => m.Episodes);
            modelBuilder.Entity<Season>().HasOptional(m => m.Series);

            modelBuilder.Entity<Actor>().HasMany(o => o.Movies);
            modelBuilder.Entity<Actor>().HasMany(o => o.Series);

            modelBuilder.Entity<Country>().HasMany(o => o.Movies);
            modelBuilder.Entity<Country>().HasMany(o => o.Series);

            modelBuilder.Entity<Director>().HasMany(o => o.Movies);
            modelBuilder.Entity<Director>().HasMany(o => o.Series);

            modelBuilder.Entity<Genre>().HasMany(o => o.Movies);
            modelBuilder.Entity<Genre>().HasMany(o => o.Series);

            modelBuilder.Entity<Language>().HasMany(o => o.Movies);
            modelBuilder.Entity<Language>().HasMany(o => o.Series);

            modelBuilder.Entity<Producer>().HasMany(o => o.Movies);
            modelBuilder.Entity<Producer>().HasMany(o => o.Series);

            modelBuilder.Entity<Writer>().HasMany(o => o.Movies);
            modelBuilder.Entity<Writer>().HasMany(o => o.Series);
            */
            base.OnModelCreating(modelBuilder);
        }
    }
}
