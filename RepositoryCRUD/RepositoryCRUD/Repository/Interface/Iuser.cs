using RepositoryCRUD.Models;

namespace RepositoryCRUD.Repository.Interface
{
    public interface Iuser
    {
        Task<IEnumerable<User>> GetUsers();

        
        
    }
}
