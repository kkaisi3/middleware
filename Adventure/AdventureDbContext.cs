using Microsoft.EntityFrameworkCore;

namespace Adventure
{
    public class AdventureDbContext : DbContext
    {
        public DbSet<Adventurer> Adventurers { get; set; }

        public AdventureDbContext(DbContextOptions<AdventureDbContext> options)
       : base(options) { }

    }

}
