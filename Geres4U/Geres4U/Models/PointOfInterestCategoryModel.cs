using System;

namespace Geres4U.Models
{
    public class PointOfInterestCategoryModel
    {
        public int CategoryID { get; set; }
        public String PointOfInterestID { get; set; }

        public virtual CategoryModel Category { get; set; }
        public virtual PointOfInterestModel PointOfInterest { get; set; }
    }
}
