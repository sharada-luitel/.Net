using StudentViewModelCrud.Models;

namespace StudentViewModelCrud.Interface
{
    public interface ITeacher
    {
        Task<List<Teacher>> GetTeachers();
        Task<int> CreateTeacher(Teacher teachers);
        Task<Teacher> GetTeacherById(int id);
        Task<bool> UpdateRecord(Teacher teachers);
        Task<bool> Delete(int id);
    }
}
