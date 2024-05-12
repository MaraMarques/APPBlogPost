using APPBlog1.Models;
using Microsoft.EntityFrameworkCore;

namespace APPBlog1.Data
{
    public class BlogDbContext : DbContext
    {

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.Blog)
                .HasForeignKey(e => e.BlogId)
                .HasPrincipalKey(e => e.Id);
        }
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

    }
}
