using Microsoft.EntityFrameworkCore;
using RepositoryCRUD.Models;

namespace RepositoryCRUD.Data
{
    public class Applicationcontext:DbContext
    {
        public Applicationcontext(DbContextOptions<Applicationcontext> options):base(options)
        {
          
        }
        public DbSet<User> Users { get; set; }

    }
}
