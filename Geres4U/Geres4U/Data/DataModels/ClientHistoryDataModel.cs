namespace Geres4U.Data.DataModels
{
    public class ClientHistoryDataModel
    {
        public string ClientID { get; set; }
        public int PointOfInterestID { get; set; }

        public ClientHistoryDataModel(string clientID, int pointOfInterestId)
        {
            ClientID = clientID;
            PointOfInterestID = pointOfInterestId;
        }
    }
}
