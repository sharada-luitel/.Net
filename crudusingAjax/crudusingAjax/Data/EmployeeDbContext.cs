using Microsoft.EntityFrameworkCore;

namespace crudusingAjax.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options): base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Parent> Parents { get; set; }
        //public DbSet<crudusingAjax.Models.EmployeeParentViewModel> EmployeeParentViewModel { get; set; } = default!;  
    }
}
