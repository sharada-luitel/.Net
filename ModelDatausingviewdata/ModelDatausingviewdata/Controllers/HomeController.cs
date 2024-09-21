using Microsoft.AspNetCore.Mvc;
using ModelDatausingviewdata.Models;
using System.Diagnostics;

namespace ModelDatausingviewdata.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Sharada",
            //    Designation = "Manager",
            //    Salary = 20000
            //};
            var myEmployee = new List<Employee>
            {
                new Employee { EmpId =101, EmpName = "Prem",Designation = "Manager",Salary = 20000 },
                new Employee { EmpId =102, EmpName = "kanchan",Designation = "Teacher",Salary = 30000 },
                new Employee { EmpId =103, EmpName = "akriti",Designation = "pilot",Salary = 40000 },
                new Employee { EmpId =104, EmpName = "prabisha",Designation = "doctor",Salary = 50000 },

            };

            ViewData["myemployee"] = myEmployee;

            //ViewData["myemployee"] = emp;
            //ViewBag.myemployee = emp;
            //TempData["myemployee"] = emp;
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
