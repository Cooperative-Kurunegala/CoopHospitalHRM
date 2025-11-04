using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class ShiftModel
    {
        public int ID { get; set; }
        public int ShiftCode { get; set; }
        public string ShiftDescription { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }

        // Collections (1-to-Many)
        public List<DayTypeModel> DayTypes { get; set; }
    }
}