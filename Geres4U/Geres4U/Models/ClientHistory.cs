using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class ClientHistory
    {
        [Required] 
        public string ClientID { get; set; }

        [Required]
        public string PointOfInterestID { get; set; }
        public virtual Client Client { get; set; }
        public virtual PointOfInterest PointOf { get; set; }
    }
}
