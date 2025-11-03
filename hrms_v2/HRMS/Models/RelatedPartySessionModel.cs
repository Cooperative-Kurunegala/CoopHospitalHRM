using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RelatedPartySessionModel
    {
        public int ID { get; set; }
        public int EPF { get; set; }
        public int PayMonth { get; set; }
        public int PayYear { get; set; }
        public string CalendarDay { get; set; }
        public int DayTypeID { get; set; }
        public string CheckInDateTime { get; set; }
        public string CheckOutDateTime { get; set; }
        public int WorkedMinutes { get; set; }
        public int LateInMinutes { get; set; }
        public int OTMinutes { get; set; }
        public int RelatedPartyID { get; set; }
        public int CompanyID { get; set; }
        public bool IsOTPaid { get; set; }

        // Navigation Properties
        public RelatedPartyModel RelatedParty { get; set; }
        public CompanyModel Company { get; set; }
        public DayTypeModel DayType { get; set; }
    }
}