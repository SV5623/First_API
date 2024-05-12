using Microsoft.EntityFrameworkCore;
using Web.API.Models.Domain;

namespace Web.API.Data
{
    public class WebDbContext: DbContext
    {
        public WebDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
                
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
