using Microsoft.AspNetCore.Mvc;

namespace Controller_and_Action.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";
            TempData.Keep();
            TempData["data4"] = new List<string>()
            {
                "Cricket","Football","Hockey"
            };

            return View();
        }

        public IActionResult About()
        {
            TempData.Keep();
            ViewBag.msg = "ghjgkjh";
            return View();
        }

        public IActionResult Contact()
        {
            TempData.Keep();
            return View();
        }

        public string Display()
        {
            return "Welcome";
        }

        public string DisplayId(int id)
        {
            return "Welcome";
        }
    }
}

//ViewBag.data1 = "Sharada";
//ViewData["data1"] = "sharada";
//ViewData["data2"] = 42;
//ViewData["data3"] = DateTime.Now.ToLongDateString();

//string[] arr = { "Kumar", "Prem", "Zain" };
//ViewData["data4"] = arr;
//ViewData["data5"] = new List<string>()
//{
//    "Cricket","Football","Hockey"
//};
