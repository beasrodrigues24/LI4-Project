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
    }
}
