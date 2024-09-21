using Microsoft.AspNetCore.Mvc;
using Modelsinaspcore.Models;
using System.Diagnostics;

namespace Modelsinaspcore.Controllers
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
            //var student = new List<StudentModel>
            //{

            //     new StudentModel{ Rollno =1,Name ="Sharada", Gender = "Female",Standard =11},
            //     new StudentModel{ Rollno =2,Name ="Akriti",Gender = "Female", Standard =11},
            //     new StudentModel{ Rollno =3,Name ="Neha",Gender = "Female",Standard =11},
            //};
            //ViewData["mystudent"] = student;

            return View(); 
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
