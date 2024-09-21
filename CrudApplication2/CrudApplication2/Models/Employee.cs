using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApplication2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column("EmployeeName",TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
