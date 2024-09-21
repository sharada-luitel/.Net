using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using StudentViewModelCrud.Interface;
using StudentViewModelCrud.Models;

namespace StudentViewModelCrud.Repository
{
    public class StudentService : IStudent
    {
        private readonly ApplicatonContext _context;
        public StudentService(ApplicatonContext context)
        {
            _context = context; 
        }
        Task<List<Student>> IStudent.GetStudents()
        {
            var student = _context.Students.ToListAsync();
            return student;
        }
        public async Task<int> CreateStudent(Student students)
        {
            await _context.Students.AddAsync(students);
            await _context.SaveChangesAsync();
            return students.Id;
        }
        public async Task<Student> GetStudentById(int Id)
        {
            var Student = await _context.Students.Where(e => e.Id == Id).FirstOrDefaultAsync();
            return Student;
        }
        public async Task<bool> Delete(int id)
        {
            bool status = false;
            if (id != 0)
            {
                var Students = _context.Students.Where(e => e.Id == id).FirstOrDefault();
                if (Students != null)
                {
                    _context.Students.Remove(Students);
                    await _context.SaveChangesAsync();
                    status = true;

                }
            }
            return status;
        }





        public async Task<bool> UpdateRecord(Student students)
        {
            bool status = false;
            if (students != null)
            {
                _context.Students.Update(students);
                await _context.SaveChangesAsync();
                status = true;
            }
            return status;

        }
    }
}
