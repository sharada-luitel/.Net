using StudentViewModelCrud.Interface;
using StudentViewModelCrud.Models;

namespace StudentViewModelCrud.Repository
{
    public class TeacherRepository : ITeacher
    {
        public Task<int> CreateTeacher(Teacher teachers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> GetTeacherById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Teacher>> GetTeachers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRecord(Teacher teachers)
        {
            throw new NotImplementedException();
        }
    }
}
