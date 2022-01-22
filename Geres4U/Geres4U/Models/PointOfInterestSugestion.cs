using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestSugestion
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "You need to provide the name of the point of interest.")]
        [MaxLength(64, ErrorMessage = "Maximum name length is 64 characters")]
        public string Name { get; set; }

        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "You need to provide the latitude of the point of interest.")]
        public double Lat { get; set; }

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "You need to provide the longitude of the point of interest.")]
        public double Long { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(255)]
        public string Description { get; set; }

        [Display(Name = "Categoria")]
        [CategoryValidation(ErrorMessage = "A Categoria inserida é inválida.")]
        [Required(ErrorMessage = "Obrigatório inserir uma categoria.")]
        public string Category { get; set; }
    }
}