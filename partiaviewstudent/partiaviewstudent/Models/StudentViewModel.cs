namespace partiaviewstudent.Models
{
    public class StudentViewModel
    {
        public List<Student> StudentsList { get; set; } = new List<Student>();
        public List<Parent> parents { get; set; }
    }
}
