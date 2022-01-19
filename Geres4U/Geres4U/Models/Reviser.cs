using System;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Reviser
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need to provide an email")]
        [MaxLength(150, ErrorMessage = "Maximum size of email is 150 characters.")]
        [DataType(DataType.EmailAddress)] // valida se o endereço de email é válido
        public String Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "The provided Emails doesn't match.")]
        public String ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must provide a password")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 5, ErrorMessage = "You need to provide a password with at least 5 characters and maximum of 32 characters.")]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(("Password"), ErrorMessage = "The provided password doesn't match.")]
        public String ConfirmPassword { get; set; }

    }
}
