using Microsoft.EntityFrameworkCore;
using OddiyBlogSayt.Domain.Entities;

namespace OddiyBlogSayt.Persistence.DataContext
{
    public class BlogPostDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public BlogPostDbContext(DbContextOptions<BlogPostDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogPostDbContext).Assembly);
        }
    }
}
