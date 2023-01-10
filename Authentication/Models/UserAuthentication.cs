using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Authentication.Models
{
    public class UserAuthentication : IValidatableObject
    {
        public int Id{ get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        public string Email{ get; set; }
        [Required(ErrorMessage ="Password is Required")]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Password) || Password.Length < 4)
            {
                yield return new ValidationResult("Password must be at least 4 characters long.", new[] { nameof(Password) });
            }

            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(Email).Success)
            {
                yield return new ValidationResult("Invalid email format.", new[] { nameof(Email) });
            }

            var regex_name = new Regex(@"^[A-Za-z ]+$");
            if (!regex_name.Match(FullName).Success || string.IsNullOrWhiteSpace(FullName))
            {
                yield return new ValidationResult("Invalid full name format.", new[] { nameof(FullName) });
            }


        }
    }
}
