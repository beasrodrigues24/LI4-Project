using System;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Geres4U.Data.DataModels
{
    public class PointOfInterestDataModel
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Images { get; set; }
        public Double Lat { get; set; }
        public Double Long { get; set; }
        public SByte isSugestion { get; set; }
        public String Description { get; set; }

        public PointOfInterestDataModel(int ID)
        {
            this.ID = ID;
            this.Name = "";
            this.Images = null;
            this.Lat = -1;
            this.Long = -1;
            this.isSugestion = 0;
            this.Description = null;
        }

        public PointOfInterestDataModel(int ID, string Name, string Images, double Lat, double Long, SByte isSugestion, string description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Images = Images;
            this.Lat = Lat;
            this.Long = Long;
            this.isSugestion = isSugestion;
            this.Description = description;
        }

        public PointOfInterestDataModel()
        {
            
        }
        
        public override bool Equals(object o)
        {
            if (o == null || !(o is PointOfInterestDataModel)) return false;
            PointOfInterestDataModel other = (PointOfInterestDataModel)o;
            return this.ID == other.ID;
        }
    }
}
