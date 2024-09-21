using CRUDAppusingADO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUDAppusingADO.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDataAccessLayer dal;
        public HomeController()
        {
            dal = new EmployeeDataAccessLayer();
        }



        public IActionResult Index()
        {
            List<Employees> emps = dal.getAllEmployees();
            return View(emps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
