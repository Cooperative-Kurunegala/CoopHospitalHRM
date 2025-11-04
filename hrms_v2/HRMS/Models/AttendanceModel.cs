using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class AttendanceModel
    {
        public int AttendanceId { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string AttendanceDate { get; set; }
        public string MiddleInteruptTimeIn { get; set; }
        public string MiddleInteruptTimeOut { get; set; }
        public int EmployeeId { get; set; }

        // Navigation Properties
        public EmployeeModel Employee { get; set; }
    }
}