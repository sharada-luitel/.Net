using Microsoft.EntityFrameworkCore;

namespace RepoViewCrud.Data
{
    public class DartaDbContext:DbContext
    {
        public DartaDbContext(DbContextOptions<DartaDbContext> options):base(options) 
        {
            
        }
        public DbSet<Darta> Dartas { get; set; }
    }
}
