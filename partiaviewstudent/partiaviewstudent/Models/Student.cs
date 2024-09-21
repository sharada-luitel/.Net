namespace partiaviewstudent.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Parent> Parents { get; set; } = new List<Parent>();



    }
}
