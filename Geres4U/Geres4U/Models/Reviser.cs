using System;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Reviser
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Comprimento máximo de 150 caracteres")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "Os emails inseridos não são iguais")]
        public String ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres, máximo de 32 caracteres")]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(("Password"), ErrorMessage = "As passwords inseridas não são iguais")]
        public String ConfirmPassword { get; set; }

    }
}
