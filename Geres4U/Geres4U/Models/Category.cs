
using System.ComponentModel.DataAnnotations;

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
    }
}
