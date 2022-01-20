using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public interface IReviserData
    {
        Task<List<ReviserDataModel>> getReviser(ReviserDataModel reviser);
    }
}
