using Joyeria.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Joyeria.Data
{
    public class JoyeriaDbContext : DbContext
    {
        public JoyeriaDbContext(DbContextOptions<JoyeriaDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
