namespace Geres4U.Data.DataModels
{
    public class PointOfInterestCategoryDataModel
    {
        public int CategoryID { get; set; }

        public string PointOfInterestID { get; set; }

        public PointOfInterestCategoryDataModel(string pointOfInterestId)
        {
            CategoryID = -1;
            PointOfInterestID = pointOfInterestId;
        }
    }
}
