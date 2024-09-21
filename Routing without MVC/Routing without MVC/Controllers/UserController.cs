using Microsoft.AspNetCore.Mvc;

namespace Routing_without_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        }
    }
}
