using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestSugestion
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(64, ErrorMessage = "Comprimento máximo de 64 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Lat { get; set; }

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Long { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(255, ErrorMessage = "Comprimento máximo de 255 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Categoria")]
        [CategoryValidation(ErrorMessage = "A categoria inserida é inválida.")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Category { get; set; }
    }
}