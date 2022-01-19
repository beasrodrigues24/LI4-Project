using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public interface IClientData
    {
        Task<List<ClientDataModel>> getClient(ClientDataModel client);
        Task InsertClient(ClientDataModel client);
    }
}
