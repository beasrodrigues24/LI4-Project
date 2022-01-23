using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace Geres4U.Models
{
    public class PointOfInterest
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Imagem")]
        public string ImagePath { get; set; }

        [Display(Name = "Latitude")]
        public double Lat { get; set; }

        [Display(Name = "Longitude")]
        public double Long { get; set; }

        public bool IsSugestion { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Categoria")]
        public string Category { get; set; }

        public PointOfInterest()
        {

        }

        public PointOfInterest(int id, string name, string imagePath, double lat, double lon, bool isSugestion, string description)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
            Lat = lat;
            Long = lon;
            IsSugestion = isSugestion;
            Description = description;
            Category = "";
        }

        public string translateCategory()
        {            
            switch (Category)
            {
                case "Passadicos": return "Passadiços";
                case "ArteRupestre": return "Arte Rupestre";
                case "EdificioRestauracao": return "Edifício Restauração";
                case "EdificioReligioso": return "Edifício Religioso";
                case "PraiaFluvial": return "Praia Fluvial";
                case "ParqueLazer": return "Parque de Lazer";
                case "ParqueNatural": return "Parque Natural";
                default: return Category;
            }
        }
    }
}