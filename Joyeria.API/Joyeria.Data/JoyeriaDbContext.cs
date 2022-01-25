using Joyeria.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Joyeria.Data
{
    public class JoyeriaDbContext : DbContext
    {
        public JoyeriaDbContext(DbContextOptions<JoyeriaDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
