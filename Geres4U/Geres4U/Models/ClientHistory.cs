using System;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class ClientHistory
    {
        [Required] 
        public String ClientID { get; set; }

        [Required]
        public String PointOfInterestID { get; set; }
        public virtual Client Client { get; set; }
        public virtual PointOfInterest PointOf { get; set; }
    }
}
