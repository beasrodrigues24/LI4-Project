using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public class PointOfInterestCategoryData
    {
        private readonly IDataAccess _db;

        public PointOfInterestCategoryData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<PointOfInterestCategoryDataModel>> getCategoryDataFromPointOfInterest(PointOfInterestCategoryDataModel p)
        {
            string sql = @"SELECT (CategoryID, PointOfInterestID) FROM dbo.PointOfInterestCategory
                           WHERE PointOfInterestID = @PointOfInterestID
                           ORDER BY CategoryID DESC";
            return _db.LoadData<PointOfInterestCategoryDataModel, dynamic>(sql, new { });
        }

        public List<CategoryDataModel> getCategoriesFromPointOfInterest(string pID)
        {
            CategoryData cID = new CategoryData(_db);
            PointOfInterestCategoryDataModel p = new PointOfInterestCategoryDataModel(pID);

            Task<List<PointOfInterestCategoryDataModel>> pointCategories = getCategoryDataFromPointOfInterest(p);
            List<PointOfInterestCategoryDataModel> categories = pointCategories.Result;
            List<CategoryDataModel> ans = new List<CategoryDataModel>();
            foreach (PointOfInterestCategoryDataModel pcDM in categories)
            {
                Task<List<CategoryDataModel>> t = cID.getCategory(new CategoryDataModel(pcDM.CategoryID));
                foreach (CategoryDataModel c in t.Result)
                {
                    ans.Add(c);
                }
            }

            return ans;
        }

        public Task InsertCategory(PointOfInterestCategoryDataModel pointOfInterestCategory)
        {
            string sql = @"INSERT INTO dbo.PointOfInterestCategory (CategoryID, PointOfInterestID)
                           VALUES (@CategoryID, @PointOfInterestID)";
            return _db.SaveData(sql, pointOfInterestCategory);
        }
    }
}
