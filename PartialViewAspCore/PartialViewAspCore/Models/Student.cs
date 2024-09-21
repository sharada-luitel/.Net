namespace PartialViewAspCore.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public Parents Parents { get; set; }
    }
}
