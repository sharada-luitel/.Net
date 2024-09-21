using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using partiaviewstudent.Models;

namespace partiaviewstudent.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _Context;
        public StudentController(StudentDbContext context)
        {
            _Context = context;

            
        }
        public IActionResult Index()
        {
            //var students = _Context.Students.Include(s => s.Parents).ToList();
            //return View(students);
            StudentViewModel sp = new StudentViewModel();
            sp.parents = _Context.Parents.ToList();
            sp.StudentsList = _Context.Students.ToList();
            return View(sp);
        }
        public IActionResult AddParent()
        {
            return PartialView("_Parent", new Parent());
        }
        public IActionResult Create()
        {
          
            var viewModel = new School
            {
                student = new Student(),
                parentslist = new List<Parent> { new Parent() } // Initialize with one empty parent
            };

            return View(viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(School viewModel)
        {

            if (ModelState.IsValid)
            {
                var stud = _Context.Students.Add(viewModel.student);
                await _Context.SaveChangesAsync();

                // Set StudentId for each Parent
                foreach (var parent in viewModel.parentslist)
                {
                    if (parent != null)
                    {

                        var pare = new Parent()
                        {
                            Name = parent.Name,
                            StudentId = stud.Entity.StudentId,
                            PhoneNumber = parent.PhoneNumber
                        };
                        _Context.Parents.Add(pare);
                    }
                }
                await _Context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);

        }


    }
}
