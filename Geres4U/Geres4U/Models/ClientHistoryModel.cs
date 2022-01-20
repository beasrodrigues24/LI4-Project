using System;

namespace Geres4U.Models
{
    public class ClientHistoryModel
    {
        public String ClientID { get; set; }
        public String PointOfInterestID { get; set; }

        public virtual ClientModel Client { get; set; }
        public virtual PointOfInterestModel PointOf { get; set; }
    }
}
