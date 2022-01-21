using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public bool IsSugestion { get; set; }

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
