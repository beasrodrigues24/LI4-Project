using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public interface IPointOfInterestData
    {
        Task<List<PointOfInterestDataModel>> GetPointsOfInterest();
        Task<List<PointOfInterestDataModel>> getPointOfInterest(PointOfInterestDataModel p);
        Task InsertPointOfInterestWithoutDescriptionAndImage(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestWithDescriptionWithoutImage(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestWithDescriptionAndImagePath(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestSugestionWithoutDescription(PointOfInterestDataModel pointOfInterest);
        Task InsertPointOfInterestSugestion(PointOfInterestDataModel pointOfInterest);
        Task acceptPointOfInterestSugestion(PointOfInterestDataModel pointOfInterest);
        Task RemovePointOfInterest(PointOfInterestDataModel pointOfInterest);
        Task addImageToPointOfInterest(PointOfInterestDataModel p, string imagePath);
        Task addDescriptionToPointOfInterest(PointOfInterestDataModel p, string description);
    }
}
