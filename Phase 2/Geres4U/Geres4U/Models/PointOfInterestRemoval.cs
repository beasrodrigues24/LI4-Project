using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestRemoval
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int id { get; set; }
    }
}
