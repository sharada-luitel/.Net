using Microsoft.AspNetCore.Mvc;
using PartialViewAspCore.Models;

namespace PartialViewAspCore.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            var student = new Student
            {
                Id = 101,
                Name = "sharada",
                RollNo = 1,
                Parents = new Parents
                {
                    FatherName = " abc",
                    MotherName = "def ",
                    Address = "Nepal",
                    PhoneNumber = 987654
                }
            };
            return View(student);
        }
    }
}
