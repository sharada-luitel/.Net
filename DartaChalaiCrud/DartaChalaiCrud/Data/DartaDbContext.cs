using Microsoft.EntityFrameworkCore;

namespace DartaChalaiCrud.Data
{
    public class DartaDbContext: DbContext
    {
        public DartaDbContext(DbContextOptions<DartaDbContext> options):base (options)
        {
            
        }
        public DbSet<Darta>Dartas { get; set; }
    }
    
    
}
