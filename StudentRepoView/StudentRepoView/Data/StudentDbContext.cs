using Microsoft.EntityFrameworkCore;
using StudentRepoView.Models;

namespace StudentRepoView.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentRepoView.Models.StudentViewModel> StudentViewModel { get; set; } = default!;
    }
}
