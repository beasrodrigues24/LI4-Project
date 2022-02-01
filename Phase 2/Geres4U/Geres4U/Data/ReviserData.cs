using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public class ReviserData
    {
        private readonly IDataAccess _db;

        public ReviserData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<ReviserDataModel>> getReviser(ReviserDataModel reviser)
        {
            string quote = "\"";
            string sql = "SELECT * FROM geres4udb.Reviser WHERE Email = " + quote + reviser.Email + quote;
            return _db.LoadData<ReviserDataModel, dynamic>(sql, reviser);
        }

    }
}
