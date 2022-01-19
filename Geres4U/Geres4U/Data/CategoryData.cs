using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public class CategoryData : ICategoryData
    {
        public readonly IDataAccess _db;

        public CategoryData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<CategoryDataModel>> getCategories()
        {
            string sql = "SELECT * FROM dbo.Category ORDER BY ID DESC";
            return _db.LoadData<CategoryDataModel, dynamic>(sql, new { });
        }

        public Task<List<CategoryDataModel>> getCategory(CategoryDataModel c)
        {
            string sql = "SELECT * FROM dbo.Category WHERE ID = @ID";
            return _db.LoadData<CategoryDataModel, dynamic>(sql, c);
        }
    }
}
