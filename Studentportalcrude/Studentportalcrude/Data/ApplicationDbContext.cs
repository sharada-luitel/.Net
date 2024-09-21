using Microsoft.EntityFrameworkCore;

namespace Studentportalcrude.Data
{
    public class ApplicationDbContext : Dbcontext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

            
        }
        public <Student> Students { get; set; }
    }
}
