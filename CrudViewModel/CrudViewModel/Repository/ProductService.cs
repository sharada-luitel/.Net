using CrudViewModel.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudViewModel.Repository
{
    public class ProductService : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductService(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return  await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);  
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();  
            
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            
        }

      

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        Task<IEnumerable<ProductService>> IProductRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<ProductService> IProductRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
