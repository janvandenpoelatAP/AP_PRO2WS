using Microsoft.EntityFrameworkCore;

namespace EFSamurai;

public class SamuraiContext : DbContext
{
    public DbSet<Samurai> Samurais { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    public DbSet<Battle> Battles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "server = localhost; database = samurai-db; user=root; password=abc123";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        optionsBuilder.LogTo(Console.WriteLine);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SamuraiBattle>()
            .HasKey(sb => new { sb.BattleId, sb.SamuraiId });
        base.OnModelCreating(modelBuilder);
    }
}
