using System.ComponentModel.DataAnnotations;

namespace crudusingAjax.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }
        public int Salary { get; set; }
        public ICollection<Parent>Parents { get; set; }
    }
}
