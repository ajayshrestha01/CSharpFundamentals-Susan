using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSys.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public DateTime Dob{ get; set; }
        public char Gender { get; set; } = 'F';
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Program { get; set; }

        public string semester { get; set; }



    }
}
