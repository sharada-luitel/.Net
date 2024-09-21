using StudentRepoView.Data;
using StudentRepoView.Models;

namespace StudentRepoView.Interface
{
    public interface IStudent
    {
        Task<List<StudentViewModel>> GetAllStudent();
        Task<StudentViewModel> GetStudentById(int id);
        Task<bool>InsertUpdateStudent(StudentViewModel student);
        Task<bool> DeleteUpdateStudent(int id);
        Task<bool> UpdateRecord(StudentViewModel student);

    }
}
