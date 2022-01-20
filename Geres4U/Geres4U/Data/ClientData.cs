using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;
using Microsoft.EntityFrameworkCore.Storage;

namespace Geres4U.Data
{
    public class ClientData : IClientData
    {
        private readonly IDataAccess _db;

        public ClientData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<ClientDataModel>> getClient(ClientDataModel client)
        {
            string sql = "SELECT * FROM geres4udb.client WHERE Email = @Email";
            return _db.LoadData<ClientDataModel, dynamic>(sql, client);
        }

        public Task InsertClient(ClientDataModel client)
        {
            string sql = @"INSERT INTO geres4udb.client (Email, Password)
                           VALUES (@Email, @Password)";
            return _db.SaveData(sql, client);
        }
    }
}
