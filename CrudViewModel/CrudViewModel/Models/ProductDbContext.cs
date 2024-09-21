using Microsoft.EntityFrameworkCore;
using CrudViewModel.Models;

namespace CrudViewModel.Models
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CrudViewModel.Models.CreateViewModel> CreateViewModel { get; set; } = default!;
    }
}
