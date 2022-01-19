
using System;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Category
    {   
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public String Name { get; set; }
    }
}
