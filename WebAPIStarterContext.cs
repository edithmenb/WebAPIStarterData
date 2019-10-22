using Microsoft.EntityFrameworkCore;
using WebAPIStarterData.Models;

namespace WebAPIStarterData
{
    public class WebAPIStarterContext : DbContext
    {
        public WebAPIStarterContext(DbContextOptions<WebAPIStarterContext> options) : base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BlogPost>()
                .HasKey(b => b.Id);

            builder.Entity<Comment>()
                .HasKey(c => c.Id);
                
            builder.Entity<BlogPost>()
                .HasMany(b => b.Comments)
                    .WithOne(c => c.BlogPost);

            builder.Entity<Comment>()
                .HasOne(c => c.BlogPost)
                    .WithMany(b => b.Comments)
                        .HasForeignKey(c => c.BlogPostId);

        }
    }

}