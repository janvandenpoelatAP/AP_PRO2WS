using Microsoft.EntityFrameworkCore;

namespace OefeningBlogEF.Entities;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
}
