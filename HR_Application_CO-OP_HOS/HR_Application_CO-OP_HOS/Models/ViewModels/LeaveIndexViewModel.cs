using System;

namespace HR_Application_CO_OP_HOS.Models.ViewModels
{
    public class LeaveIndexViewModel
    {
        public int LeaveID { get; set; }
        public string EmployeeFullName { get; set; }
        public string LeaveTypeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalDays { get; set; }
        public string Status { get; set; }
    }
}