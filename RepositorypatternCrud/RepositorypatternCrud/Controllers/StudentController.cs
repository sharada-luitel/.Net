using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RepositorypatternCrud.Models;
using RepositorypatternCrud.Repository;

namespace RepositorypatternCrud.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent Sharada;
        public StudentController(IStudent student)
        {
            Sharada = student;
        }
        public async Task<IActionResult > Index()
        {
            var data = await Sharada.GetStudents();
            return View(data);

            //return View(Sharada.GetStudents());
        }
        public IActionResult Create()
        {
            return View();
           // return View(Sharada.GetStudents());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student students)
        {
            //try
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return View(students);
            //    }
            //    else
            //    {
            //        await Sharada.CreateStudent(students);

            //    }

               
            //}
            //catch(Exception)
            //{
            //    throw;
            //}
            //return RedirectToAction("Index");


            if (!ModelState.IsValid)
            {
                return View(students);
            }
            else
            {
                await Sharada.CreateStudent(students);
                if(students.Id == 0)
                {
                    TempData["StudentError"] = "Record Not Saved";
                }
                else
                {
                    TempData["StudentSuccess"] = "Record Successfully saved!";
                }

            }
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Edit(int Id)
        {
            Student Students = new Student();
            if (Id == 0)
            {
                return BadRequest();
            }
            else
            {
                Students = await Sharada.GetStudentById(Id);
                if(Students ==null)
                {
                    return NotFound();
                }
            }
            return View(Students);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student students)
        {
            if (!ModelState.IsValid)
            {
                return View(students);
            }
            else
            {
                bool status =  await Sharada.UpdateRecord(students);
                if (status)
                {
                    TempData["StudentSuccess"] = "Your Record has been successfully updated!";
                }
                else
                {
                    TempData["studentError"] = "Record Has not been Updated";
                }
                return RedirectToAction("Index");   


            }

        }



        public IActionResult AddParent()
        {
            return PartialView("_parentPartial", new Student());
        }



        public async Task<IActionResult> Delete(int Id)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
            else
            {
                bool status = await Sharada.Delete(Id);
                if(status)
                {
                    TempData["StudentSuccess"] = "Record has been successfully Deleted";
                }
                else
                {
                    TempData["StudentError"] = "Record Not Deleted";
                }

            }
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Details(int Id)
        {
            Student Students = new Student();
            if (Id == 0)
            {
                return BadRequest();
            }
            else
            {
                Students = await Sharada.GetStudentById(Id);
                if (Students == null)
                {
                    return NotFound();
                }
            }
            return View(Students);
        }




    }
}
