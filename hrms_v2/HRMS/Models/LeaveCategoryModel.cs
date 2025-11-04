using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class LeaveCategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string LeaveCode { get; set; }

        // Collections (1-to-Many)
        public List<LeaveMasterModel> LeaveMasters { get; set; }
    }
}