using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public interface ICategoryData
    {
        Task<List<CategoryDataModel>> getCategories();
        Task<List<CategoryDataModel>> getCategory(CategoryDataModel c);
    }
}
