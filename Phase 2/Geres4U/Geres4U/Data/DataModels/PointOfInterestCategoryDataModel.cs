using System;

namespace Geres4U.Data.DataModels
{
    public class PointOfInterestCategoryDataModel
    {
        public int CategoryID { get; set; }

        public int PointOfInterestID { get; set; }

        public PointOfInterestCategoryDataModel(int pointOfInterestId)
        {
            CategoryID = -1;
            PointOfInterestID = pointOfInterestId;
        }

        public PointOfInterestCategoryDataModel(Int32 CategoryID, Int32 PointOfInterestID)
        {
            this.CategoryID = CategoryID;
            this.PointOfInterestID = PointOfInterestID;
        }

        public PointOfInterestCategoryDataModel(Int32 CategoryID, bool isCat)
        {
            this.CategoryID = CategoryID;
            this.PointOfInterestID = -1;
        }
    }
}


