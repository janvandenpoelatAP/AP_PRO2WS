using Microsoft.EntityFrameworkCore;

namespace HelloCore.Entities
{
    public class HelloCoreDbContext : DbContext
    {
        public HelloCoreDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
