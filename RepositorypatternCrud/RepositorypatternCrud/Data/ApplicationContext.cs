using Microsoft.EntityFrameworkCore;
using RepositorypatternCrud.Models;

namespace RepositorypatternCrud.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}