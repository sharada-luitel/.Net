using CrudApplication2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CrudApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDBContext employeeDb;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(EmployeeDBContext EmployeeDb)
        {
            employeeDb = EmployeeDb;
        }

        public async Task< IActionResult> Index()
        {
            var empdata = await employeeDb.Employees.ToListAsync();
            return View(empdata);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                await employeeDb.Employees.AddAsync(emp);
                await employeeDb.SaveChangesAsync();
                TempData["insert_success"] = "Inserted";
                return RedirectToAction("Index", "Home");

            }
            return View(emp);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null || employeeDb.Employees == null)
            {
                return NotFound();
            }
            var empdata = await employeeDb.Employees.FirstOrDefaultAsync(x=> x.Id == id);
            if(empdata == null)
            {
                return NotFound();
            }
            return View(empdata);
        }
        public  async Task<IActionResult> Edit(int? id)
        {

            if (id == null || employeeDb.Employees == null)
            {
                return NotFound();
            }
            var empData = await employeeDb.Employees.FindAsync(id);
            if (empData == null)
            {
                return NotFound();
            }
            return View(empData);
        }
        [HttpPost]
        public async Task< IActionResult> Edit(int? id ,Employee emp)
        {
            if(id!= emp.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                employeeDb.Update(emp);
                await employeeDb.SaveChangesAsync();
                TempData["Update_success"] = "Updated";
                return RedirectToAction("Index", "Home");

            }
            return View(emp);
        }
        public  async Task<IActionResult> Delete(int? id)
        {
            if (id == null || employeeDb.Employees == null)
            {
                return NotFound();
            }
            var empdata = await employeeDb.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (empdata == null)
            {
                return NotFound();
            }
            return View(empdata);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var empData = await employeeDb.Employees.FindAsync(id);
            if(empData != null)
            {
                employeeDb.Employees.Remove(empData);
            }
            await employeeDb.SaveChangesAsync();
            TempData["Delete_success"] = "Deleted";
            return RedirectToAction("Index", "Home");
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
