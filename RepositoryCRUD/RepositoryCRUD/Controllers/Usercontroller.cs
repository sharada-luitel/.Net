using Microsoft.AspNetCore.Mvc;
using RepositoryCRUD.Repository.Interface;

namespace RepositoryCRUD.Controllers
{
    public class Usercontroller : Controller
    {
        private readonly Iuser userReposiitory;

        public Usercontroller(Iuser userReposiitory)
        {
            this.userReposiitory = userReposiitory;
        }
       public async Task<IActionResult>GetUsersList()
        {
            var data = await userReposiitory.GetUsers();
            return View(data);

        }
    }
}
