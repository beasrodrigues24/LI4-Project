using System.Collections.Generic;
using System.Globalization;
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
            string quote = "\"";
            string sql = @"SELECT * FROM geres4udb.clienthistory
                           WHERE ClientID = " + quote + c.ClientID + quote;
            return _db.LoadData<ClientHistoryDataModel, dynamic>(sql, new { });
        }

        public Task InsertHistory(ClientHistoryDataModel clientHistory)
        {
            string quote = "\"";
            string sql = @"INSERT INTO geres4udb.clienthistory (ClientID, PointOfInterestID)
                           VALUES (" + quote + clientHistory.ClientID + quote + ", "  + clientHistory.PointOfInterestID +")";
            return _db.SaveData(sql, clientHistory);
        }

        public Task RemoveHistory(ClientHistoryDataModel client)
        {
            string quote = "\"";
            string sql = @"DELETE FROM geres4udb.clienthistory 
                           WHERE ClientID = " + quote + client.ClientID  + quote + " AND PointOfInterestID = " + client.PointOfInterestID;
            return _db.SaveData(sql, client);
        }

        public Task RemoveHistoryFromPointOfInterest(ClientHistoryDataModel client)
        {
            string sql = "DELETE FROM geres4udb.clienthistory WHERE (`PointOfInterestID` = '" + client.PointOfInterestID + "')";
            return _db.SaveData(sql, client);
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
