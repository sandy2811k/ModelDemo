using System.ComponentModel.DataAnnotations;

namespace ModelDemo.Models
{
    public class Employee:IValidatableObject
    {
        [Required(ErrorMessage ="EmpId is Required")]
        [Display(Name="Employee Id")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Employee Name")]
        [MaxLength(50,ErrorMessage ="Name must have less then 50 charecters")]
        [MinLength(2)]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }

        [Required]
        public Double Salary { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }

        [Display(Name="Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]

        [Compare("Password",ErrorMessage ="Password does Not Match")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var PName = new[] { "Dob" };
            if (Dob > DateTime.Now)
            {
                yield return new ValidationResult("Date of birth can not be in future", PName);
            }
            if (Dob < DateTime.Now.AddYears(-100))
            {
                yield return new ValidationResult("Date of birth can not be in too past", PName);
            }
        }



    }
}
