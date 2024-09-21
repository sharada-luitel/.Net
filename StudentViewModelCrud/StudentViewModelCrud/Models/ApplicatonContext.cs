using Microsoft.EntityFrameworkCore;

namespace StudentViewModelCrud.Models
{
    public class ApplicatonContext : DbContext
    {
        public ApplicatonContext(DbContextOptions<ApplicatonContext> options):base(options)
        {

            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
