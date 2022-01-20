using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Client
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need to provide an email")]
        [DataType(DataType.EmailAddress)] // valida se o endereço de email é válido
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must provide a password")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 5, ErrorMessage = "You need to provide a password with at least 5 characters and maximum of 32 characters.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(("Password"), ErrorMessage = "The provided password doesn't match.")]
        public string ConfirmPassword { get; set; }

        public HashSet<PointOfInterest> History { get; set; }

    }
}
