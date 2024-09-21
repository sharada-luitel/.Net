using Modelsinaspcore.Models;

namespace Modelsinaspcore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudent()
        {
            return DataSource();
            
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.Rollno == id).FirstOrDefault();
           
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                {

                     new StudentModel{ Rollno =1,Name ="Sharada", Gender = "Female",Standard =11},
                     new StudentModel{ Rollno =2,Name ="Akriti",Gender = "Female", Standard =11},
                     new StudentModel{ Rollno =3,Name ="Neha",Gender = "Female",Standard =11},
                      new StudentModel{ Rollno =4,Name ="Akriti",Gender = "Female", Standard =11},
                     new StudentModel{ Rollno =5,Name ="Neha",Gender = "Female",Standard =11},
                };

                }
            }


    }
}
