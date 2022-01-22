using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Client
    {
        [Display(Name = "Indique o seu email:")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }

        [Display(Name = "Introduza uma palavra passe:")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "Mínimo de 6 caracteres, máximo de 32 caracteres")]
        public string Password { get; set; }

        [Display(Name = "Reintroduza a palavra passe escolhida:")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [Compare(("Password"), ErrorMessage = "Passwords inseridas não são iguais")]
        public string ConfirmPassword { get; set; }
    }
}
