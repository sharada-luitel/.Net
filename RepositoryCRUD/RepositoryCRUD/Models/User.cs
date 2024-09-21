using System.ComponentModel.DataAnnotations;

namespace RepositoryCRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public String Name { get; set; } = default!;
        public String Gender { get; set; } = default!;
        public String Email { get; set; } = default!;
        public int PinCode { get; set; } 
        public bool IsActive { get; set; } 

    }
}
