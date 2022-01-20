using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public interface IClientHistoryData
    {
        public Task<List<ClientHistoryDataModel>> getHistoryDataModelFromClient(ClientHistoryDataModel c);
        public Task InsertHistory(ClientHistoryDataModel clientHistory);
        Task RemoveHistory(ClientHistoryDataModel client);
        public List<PointOfInterestDataModel> getHistoryFromClient(string email);
    }
}
