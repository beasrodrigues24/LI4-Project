using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public class ReviserData : IReviserData
    {
        private readonly IDataAccess _db;

        public ReviserData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<ReviserDataModel>> getReviser(ReviserDataModel reviser)
        {
            string sql = "SELECT * FROM dbo.Reviser WHERE Email = @Email";
            return _db.LoadData<ReviserDataModel, dynamic>(sql, reviser);
        }

        public Task InsertReviser(ReviserDataModel reviser)
        {
            string sql = @"INSERT INTO dbo.Reviser (Email, Password)
                           VALUES (@Email, @Password)";
            return _db.SaveData(sql, reviser);
        }
    }
}
