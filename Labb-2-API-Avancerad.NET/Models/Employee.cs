using System.ComponentModel.DataAnnotations;

namespace Labb_2_API_Avancerad.NET.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public string? Address { get; set; }
        
        public string? ZipCode { get; set; }
        
        public string? City { get; set; }
        
        public string? Phone { get; set; }
        
        public decimal? Salary { get; set; }

        [Required(ErrorMessage = "Please choose an option.")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Where is he going to work?")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public string? FullName { get; set; }


    }
}
