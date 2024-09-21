using Microsoft.EntityFrameworkCore;
using StudentRepoView.Data;
using StudentRepoView.Interface;
using StudentRepoView.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentRepoView.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly StudentDbContext _Context;
        public StudentRepository(StudentDbContext context)
        {
            _Context = context;

        }
        public async Task<List<StudentViewModel>> GetAllStudent()
        {
            return await _Context.Students.Select(x => new StudentViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                //Gender = x.Gender,
                Standard = x.Standard,

            }).ToListAsync();
        }
       



        public async Task<StudentViewModel> GetStudentById(int id)
        {
            var result = await _Context.Students
               .Where(x => x.Id == id)
               .Select(x => new StudentViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   Address = x.Address,
                   //Gender = x.Gender,
                   Standard = x.Standard,
               })
               .FirstOrDefaultAsync();

            return result ?? new StudentViewModel();
        }

        public async Task<bool> InsertUpdateStudent(StudentViewModel student)
        {
            try
            {
                if (student.Id > 0)
                {
                    var data = await _Context.Students.FirstOrDefaultAsync(x => x.Id == student.Id);
                    if (data != null)
                    {
                        data.Name = student.Name;
                        data.Address = student.Address;
                        //data.Gender = student.Gender;
                        data.Standard = student.Standard;


                       _Context.Entry(data).State = EntityState.Modified;
                        await _Context.SaveChangesAsync();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    var newdata = new Student()
                    {
                        Name = student.Name,
                        Address = student.Address,
                        //Gender = student.Gender,
                        Standard = student.Standard,


                    };
                    await _Context.Students.AddAsync(newdata);
                    await _Context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteUpdateStudent(int id)
        {
            bool status = false;
            if (id != 0)
            {
                var Students = _Context.Students.Where(e => e.Id == id).FirstOrDefault();
                if (Students != null)
                {
                    _Context.Students.Remove(Students);
                    await _Context.SaveChangesAsync();
                    status = true;

                }
            }
            return status;
        }


        public async Task<bool> UpdateRecord(StudentViewModel student)
        {
            if (student.Id > 0)
            {
                var data = await _Context.Students.FirstOrDefaultAsync(x => x.Id == student.Id);
                if (data != null)
                {
                    data.Name = student.Name;
                    data.Address = student.Address;
                    //data.Gender = student.Gender;
                    data.Standard = student.Standard;
                    _Context.Entry(data).State = EntityState.Modified;
                    await _Context.SaveChangesAsync();
                }
                else
                {
                    return false;
                }

            }
            return false;




        }
    }
}
