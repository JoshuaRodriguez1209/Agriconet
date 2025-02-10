using System.Security.Cryptography.X509Certificates;
using AgriConet.Shared;
using Microsoft.EntityFrameworkCore;

namespace AgriConet.Web.Data
{
    public class DataContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DataContext(DbContextOptions<DataContext> options): base
        (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
