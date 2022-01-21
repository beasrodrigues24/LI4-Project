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
            string sql = @"SELECT * FROM geres4udb.pointofinterestcategory WHERE PointOfInterestID = " + p.PointOfInterestID;
            return _db.LoadData<PointOfInterestCategoryDataModel, dynamic>(sql, new { });
        }

        public List<CategoryDataModel> getCategoriesFromPointOfInterest(int pID)
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

        public Task<List<PointOfInterestCategoryDataModel>> getPointsFromCategoryDataModel(PointOfInterestCategoryDataModel c)
        {
            string sql = @"SELECT * FROM geres4udb.pointofinterestcategory
                           WHERE CategoryID = " + c.CategoryID;
            return _db.LoadData<PointOfInterestCategoryDataModel, dynamic>(sql, new { });
        }

        public Task InsertCategory(PointOfInterestCategoryDataModel pointOfInterestCategory)
        {
            string sql = @"INSERT INTO geres4udb.pointofinterestcategory (CategoryID, PointOfInterestID)
                           VALUES (" + pointOfInterestCategory.CategoryID + ", " + pointOfInterestCategory.PointOfInterestID + ")"; 
            return _db.SaveData(sql, pointOfInterestCategory);
        }

        
        public List<PointOfInterestDataModel> getPointsWithCategory(int category)
        {
            PointOfInterestData piD = new PointOfInterestData(_db);
            PointOfInterestCategoryDataModel pDM = new PointOfInterestCategoryDataModel(category, true);
            Task<List<PointOfInterestCategoryDataModel>> pointsFromCat = getPointsFromCategoryDataModel(pDM);
            List<PointOfInterestCategoryDataModel> ps = pointsFromCat.Result;
            List<PointOfInterestDataModel> ans = new List<PointOfInterestDataModel>();
            foreach (PointOfInterestCategoryDataModel piDM in ps)
            {
                Task<List<PointOfInterestDataModel>> t = piD.getPointOfInterest(new PointOfInterestDataModel(piDM.PointOfInterestID));
                foreach (PointOfInterestDataModel p in t.Result)
                {
                    ans.Add(p);
                }
            }

            return ans;
        }
        
    }
}
