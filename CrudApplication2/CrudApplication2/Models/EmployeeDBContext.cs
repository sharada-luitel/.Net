using Microsoft.EntityFrameworkCore;

namespace CrudApplication2.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {

            
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
