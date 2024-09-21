using CrudViewModel.Models;

namespace CrudViewModel.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductService>> GetAllAsync(); 
        Task<ProductService> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);   
    }
}
