using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class LeaveMasterModel
    {
        public int ID { get; set; }
        public int ApprovedBy { get; set; }
        public string ApprovedDateTime { get; set; }
        public int RecommendedBy { get; set; }
        public string RecommendedDateTime { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string LeaveFrom { get; set; }
        public string LeaveTo { get; set; }
        public double NoOfLeaves { get; set; }
        public int RelatedPartyID { get; set; }

        // Navigation Properties
        public RelatedPartyModel RelatedParty { get; set; }
    }
}