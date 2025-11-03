using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class AttendanceModel
    {
        public int AttendanceId { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DateTime Attendance_Date {get; set; }
        public DateTime MiddleInteruptTimeIn { get; set; }
        public DateTime MiddleInteruptTimeOut { get; set; }
        //Create A Foreign Key Relationship With Employee
        public int EmployeeId { get; set; }
        public virtual EmployeeModel Employee { get; set; }
    }
}