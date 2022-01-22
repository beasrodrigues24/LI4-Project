using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class SpecificPointOfInterestQuery
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int ID { get; set; }
    }
}
