using Modelsinaspcore.Models;

namespace Modelsinaspcore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudent();
        StudentModel getStudentById(int id);

    }
}
