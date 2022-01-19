using System;

namespace Geres4U.Models
{
    public class ClientHistory
    {
        public String ClientID { get; set; }
        public String PointOfInterestID { get; set; }

        public virtual Client Client { get; set; }
        public virtual PointOfInterest PointOf { get; set; }
    }
}
