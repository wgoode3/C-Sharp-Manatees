using Microsoft.EntityFrameworkCore;
using Manatees.Models;

namespace Manatees.Models {
    public class ManateeContext : DbContext {
        public ManateeContext(DbContextOptions options) : base(options) { }
        public DbSet<Actor> Actresses {get;set;}
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Cast> Casts {get;set;}

        public void Create(Movie m)
        {
            Movies.Add(m);
            SaveChanges();
        }

        public void Create(Actor a)
        {
            Actresses.Add(a);
            SaveChanges();
        }

        public void Create(Cast c)
        {
            Casts.Add(c);
            SaveChanges();
        }

    }
}