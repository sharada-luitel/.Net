using Microsoft.AspNetCore.Mvc;

namespace DartaChalaiCrud.Controllers
{
    public class DartaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
