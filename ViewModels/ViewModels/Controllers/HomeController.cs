using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModels.Models;

namespace ViewModels.Controllers
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
            List<Student> students = new List<Student>
            {
                new Student { Id=1,Name="Sharada",Gender="Female",Standard=11},
                 new Student { Id=1,Name="AAkriti",Gender="Female",Standard=12},
                 new Student { Id=1,Name="Sagar",Gender="Male",Standard=13},
             };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Id=1,Name="Sharada", Qualification="bbs",Salary=2000},
                 new Teacher { Id=1,Name="AAkriti",Qualification="Mit",Salary=3000},
                  new Teacher { Id=1,Name="Sagar",Qualification="Csit",Salary=4000},
             };

            SchoolViewModel svm = new SchoolViewModel()
            {
                mystudents = students,
                myteachers = teachers
            };
            return View(svm);
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
