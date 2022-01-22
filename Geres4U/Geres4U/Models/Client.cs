using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Client
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "Mínimo de 6 caracteres, máximo de 32 caracteres")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [Compare(("Password"), ErrorMessage = "Passwords inseridas não são iguais")]
        public string ConfirmPassword { get; set; }
    }
}
