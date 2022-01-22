using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestToUpdate
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(64, ErrorMessage = "Comprimento máximo de 64 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Imagem")]
        [MaxLength(2048, ErrorMessage = "Comprimento máximo de 2048 caracteres.")]
        public string ImagePath { get; set; }

        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Lat { get; set; }

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Long { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(255, ErrorMessage = "Comprimento máximo de 64 caracteres")]
        public string Description { get; set; }
    }
}
