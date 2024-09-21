using Microsoft.EntityFrameworkCore;
using RepositoryCRUD.Data;
using RepositoryCRUD.Models;
using RepositoryCRUD.Repository.Interface;

namespace RepositoryCRUD.Repository.Services
{
    public class Userservice : Iuser
    {
        private readonly Applicationcontext context;

        public Userservice(Applicationcontext context)
        {
            this.context = context;
        }

        public Task<IEnumerable<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var data =  await context.Users.ToListAsync();
            return data;
            
        }
    }
}
