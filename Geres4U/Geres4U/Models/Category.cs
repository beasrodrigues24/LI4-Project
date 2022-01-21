
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Geres4U.Models
{
    public class Category
    {   
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category(string name)
        {
            Name = name;
            Id = translateNameToID(name);
        }

        public int translateNameToID(String name)
        {
            switch (name)
            {
                case "Cascata": return 1;
                case "Lagoa": return 2;
                case "Miradouro": return 3;
                case "Grutas": return 4;
                case "Passadicos": return 5;
                case "Ponte": return 6;
                case "ArteRupestre": return 7;
                case "Espigueiros": return 8;
                case "Ecovia": return 9;
                case "EdificioRestauracao": return 10;
                case "Termas": return 11;
                case "Aldeias": return 12;
                case "Monumentos": return 13;
                case "EdificioReligioso": return 14;
                case "PraiaFluvial": return 15;
                case "ParqueLazer": return 16;
                case "ParqueNatural": return 17;
                case "Trilhos": return 18;
                default: return -1;
            }
        }
    }
}
