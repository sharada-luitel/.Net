using ASPCoreWithjQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPCoreWithjQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        public Calculation Calculate (int num1, int num2)
        {
            Calculation mod = new Calculation();
            mod.Add = num1 + num2;
            mod.Subtract = num1 - num2;
            mod.Multiply = num1 * num2;
            mod.Division= (Double)num1 / num2;
            return mod;

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
