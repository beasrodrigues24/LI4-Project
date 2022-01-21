using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestSugestion
    {
        [Required(ErrorMessage = "You need to provide the name of the point of interest.")]
        [MaxLength(64, ErrorMessage = "Maximum name length is 64 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to provide the latitude of the point of interest.")]
        public double Lat { get; set; }

        [Required(ErrorMessage = "You need to provide the longitude of the point of interest.")]
        public double Long { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
