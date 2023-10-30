using System.ComponentModel.DataAnnotations;

namespace ModelDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Roll Number is Required")]
        [Display(Name = "Student Roll Number")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Student Name")]
        [MaxLength(50, ErrorMessage = "Name must have less then 50 charecters")]
        [MinLength(2)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "City Name is Required")]
        [Display(Name = "City Name")]
        [DataType(DataType.Text)]
        public string? City { get; set; }

        [Required(ErrorMessage = "Branch is Required")]
        [Display(Name = "Branch")]
        public string? Branch { get; set; }

        [Required(ErrorMessage = "Percentage is Required")]
        public Double Persentage { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
    }
}
