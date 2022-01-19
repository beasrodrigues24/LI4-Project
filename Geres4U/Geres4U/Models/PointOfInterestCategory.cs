using System;

namespace Geres4U.Models
{
    public class PointOfInterestCategory
    {
        public int CategoryID { get; set; }
        public String PointOfInterestID { get; set; }

        public virtual Category Category { get; set; }
        public virtual PointOfInterest PointOfInterest { get; set; }
    }
}
