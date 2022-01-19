using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public class ClientHistoryData : IClientHistoryData
    {
        private readonly IDataAccess _db;

        public ClientHistoryData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<ClientHistoryDataModel>> getHistoryDataModelFromClient(ClientHistoryDataModel c)
        {
            string sql = @"SELECT (ClientID, PointOfInterestID) FROM dbo.ClientHistory
                           WHERE ClientID = @ClientID
                           ORDER BY PointOfInterestID DESC";
            return _db.LoadData<ClientHistoryDataModel, dynamic>(sql, new { });
        }

        public Task InsertHistory(ClientHistoryDataModel clientHistory)
        {
            string sql = @"INSERT INTO dbo.ClientHistory (ClientID, PointOfInterestID)
                           VALUES (@ClientID, @PointOfInterestID)";
            return _db.SaveData(sql, clientHistory);
        }

        // maybe colocar isto noutro sítio
        public List<PointOfInterestDataModel> getHistoryFromClient(string email)
        {
            PointOfInterestData piD = new PointOfInterestData(_db);
            ClientHistoryDataModel cH = new ClientHistoryDataModel(email, -1);
            Task<List<ClientHistoryDataModel>> clientHistory = getHistoryDataModelFromClient(cH);
            List<ClientHistoryDataModel> history = clientHistory.Result;
            List<PointOfInterestDataModel> ans = new List<PointOfInterestDataModel>();
            foreach (ClientHistoryDataModel chDM in history)
            {
                Task<List<PointOfInterestDataModel>> t = piD.getPointOfInterest(new PointOfInterestDataModel(chDM.PointOfInterestID));
                foreach (PointOfInterestDataModel p in t.Result)
                {
                    ans.Add(p);
                }
            }

            return ans;
        }
    }
}
