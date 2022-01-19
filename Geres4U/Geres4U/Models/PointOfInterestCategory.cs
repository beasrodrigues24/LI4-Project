using System;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class PointOfInterestCategory
    {
        public int Id { get; set; }

        [Required]
        public int CategoryID { get; set; }
        [Required]
        public String PointOfInterestID { get; set; }

        public virtual Category Category { get; set; }
        public virtual PointOfInterest PointOfInterest { get; set; }
    }
}
