using System;

namespace Geres4U.Data.DataModels
{
    public class ClientHistoryDataModel
    {
        public string ClientID { get; set; }
        public int PointOfInterestID { get; set; }

        public ClientHistoryDataModel(String clientID, Int32 pointOfInterestId)
        {
            ClientID = clientID;
            PointOfInterestID = pointOfInterestId;
        }

        public ClientHistoryDataModel(int pointOfInterestID)
        {
            ClientID = "";
            PointOfInterestID = pointOfInterestID;
        }
    }
}
