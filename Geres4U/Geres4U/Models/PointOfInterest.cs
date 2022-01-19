using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to provide the name of the point of interest.")]
        [MaxLength(64, ErrorMessage = "Maximum name length is 64 characters")]
        public String Name { get; set; }

        public String ImagePath { get; set; }

        [Required(ErrorMessage = "You need to provide the latitude of the point of interest.")]
        public Double Lat { get; set; }

        [Required(ErrorMessage = "You need to provide the longitude of the point of interest.")]
        public Double Long { get; set; }

        public Boolean IsSugestion { get; set; }

        [MaxLength(255)]
        public String Description { get; set; }

        public HashSet<Category> Categories { get; set; }

    }
}
