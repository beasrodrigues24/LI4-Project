using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Geres4U.Data.DataModels
{
    public class PointOfInterestDataModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public bool isSugestion { get; set; }
        public string Description { get; set; }

        public PointOfInterestDataModel(int ID)
        {
            this.ID = ID;
            this.Name = "";
            this.Images = null;
            this.Lat = -1;
            this.Long = -1;
            this.isSugestion = false;
            this.Description = null;
        }

        public PointOfInterestDataModel(int ID, string Name, string Images, double Lat, double Long, bool isSugestion, string description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Images = Images;
            this.Lat = Lat;
            this.Long = Long;
            this.isSugestion = isSugestion;
            this.Description = description;
        }
    }
}
