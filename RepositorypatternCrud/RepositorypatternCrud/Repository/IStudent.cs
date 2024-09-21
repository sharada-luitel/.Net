using RepositorypatternCrud.Models;
namespace RepositorypatternCrud.Repository
{
    public interface IStudent
    {
        Task<List<Student>> GetStudents();
        Task<int> CreateStudent(Student students);
        Task<Student> GetStudentById(int id);
        Task<bool> UpdateRecord(Student student);
        Task<bool> Delete(int id);
        
    }
}
