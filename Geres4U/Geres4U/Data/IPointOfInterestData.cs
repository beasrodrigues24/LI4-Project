using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public interface IPointOfInterestData
    {
        Task<List<PointOfInterestDataModel>> GetPointsOfInterest();
        Task getPointOfInterest(PointOfInterestDataModel p);
        Task InsertPointOfInterestWithoutDescriptionAndImage(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestWithDescriptionWithoutImage(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestWithDescriptionAndImagePath(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestSugestionWithoutDescription(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestSugestion(PointOfInterestDataModel pointOfInterest);
    }
}
