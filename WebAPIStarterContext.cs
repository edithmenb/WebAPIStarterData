using Microsoft.EntityFrameworkCore;
using WebAPIStarterData.Models;

namespace WebAPIStarterData
{
    public class WebAPIStarterContext: DbContext
    {
        public WebAPIStarterContext (DbContextOptions<WebAPIStarterContext> options): base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
    }

}