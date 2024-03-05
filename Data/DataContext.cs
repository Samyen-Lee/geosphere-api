using geosphere_api.Models;
using Microsoft.EntityFrameworkCore;

namespace geosphere_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Ressource> Ressources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ressource>().Ignore(x => x.Place);
        }
    }
}
