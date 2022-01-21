using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestByReviser
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "You need to provide the name of the point of interest.")]
        [MaxLength(64, ErrorMessage = "Maximum name length is 64 characters.")]
        public string Name { get; set; }

        [Display(Name = "Imagem")]
        [MaxLength(2048, ErrorMessage = "Maximum path length is 2048 characters.")]
        public string ImagePath { get; set; }

        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "You need to provide the latitude of the point of interest.")]
        public double Lat { get; set; }

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "You need to provide the longitude of the point of interest.")]
        public double Long { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(255)]
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
