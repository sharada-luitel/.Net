using Microsoft.EntityFrameworkCore;

namespace partiaviewstudent.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
    }

}

