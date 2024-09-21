using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentRepoView.Data;
using StudentRepoView.Interface;
using StudentRepoView.Models;

namespace StudentRepoView.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _Student = null;
        public StudentController(IStudent StudentRepository)
        {
            _Student = StudentRepository;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _Student.GetAllStudent();
            return View(list);
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await _Student.GetStudentById(id));

        }
        public async Task<IActionResult> Create(StudentViewModel student)
        {

            if (ModelState.IsValid)
            {
                if (await _Student.InsertUpdateStudent(student))
                {
                    TempData["msg"] = "success";
                    return RedirectToAction("Index");
                }
            }
            //ViewBag.Gender = new SelectList(new List<string>() { "Male", "Female", "Others" });
            return View(student);
        }

      
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else
            {
                bool status = await _Student.DeleteUpdateStudent(id);
                if (status)
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _Student.GetStudentById(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StudentViewModel student)
        {
            if (!ModelState.IsValid)
            {
                if(await _Student.UpdateRecord(student))
                {
                    TempData["msg"] = "success";
                    return RedirectToAction("Index");

                }
            }
            return View(student);


            }
           

        }

    }


    
