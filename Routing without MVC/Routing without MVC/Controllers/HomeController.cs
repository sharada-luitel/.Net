using Microsoft.AspNetCore.Mvc;

namespace Routing_without_MVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]

        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/About")]


        public IActionResult About()
        {
            return View();
        }
        [Route("Home/Details/{id?}")]

        public int Details(int? id)
        {
            return id ?? 1;
        }

    }
}
