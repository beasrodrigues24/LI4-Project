using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestModel
    {
        public String ID { get; set; }

        [Required(ErrorMessage = "You need to provide the name of the point of interest.")]
        public String Name{ get; set; }

        public String ImagePath { get; set; }

        [Required(ErrorMessage = "You need to provide the latitude of the point of interest.")]
        public Double Lat { get; set; }

        [Required(ErrorMessage = "You need to provide the longitude of the point of interest.")]
        public Double Long { get; set; }

        public Boolean IsSugestion { get; set; }

        public String Description { get; set; }

        public HashSet<CategoryModel> Categories { get; set; }

    }
}
