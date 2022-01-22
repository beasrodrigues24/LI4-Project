using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Authentication
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
