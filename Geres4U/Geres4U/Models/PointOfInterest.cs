using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to provide the name of the point of interest.")]
        [MaxLength(64, ErrorMessage = "Maximum name length is 64 characters")]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [Required(ErrorMessage = "You need to provide the latitude of the point of interest.")]
        public double Lat { get; set; }

        [Required(ErrorMessage = "You need to provide the longitude of the point of interest.")]
        public double Long { get; set; }

        public bool IsSugestion { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public HashSet<Category> Categories { get; set; }

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
            Categories = new HashSet<Category>();
        }

        public void addCategory(Category c)
        {
            Categories.Add(c);
        }
    }
}
