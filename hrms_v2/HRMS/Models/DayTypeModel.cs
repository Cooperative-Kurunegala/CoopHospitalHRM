using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class DayTypeModel
    {
        public int ID { get; set; }
        public string DayTypeName { get; set; }
        public int ShiftID { get; set; }

        // Navigation Properties
        public ShiftModel Shift { get; set; }

        // Collections (1-to-Many)
        public List<RelatedPartySessionModel> Sessions { get; set; }
    }
}