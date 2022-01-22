using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestRemoval
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "Obrigatório inserir o id")]
        public int id { get; set; }
    }
}
