using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class CurrentPayrollMonthModel
    {
        public int ID { get; set; }
        public int CurrentPayrollMonthValue { get; set; }
        public int CurrentPayrollYearValue { get; set; }
        public int SalaryTypeID { get; set; }
        public int CompanyID { get; set; }
        public bool IsCurrentPayrollMonth { get; set; }
        public string MonthName { get; set; }
        public bool IsClosed { get; set; }
        public string DurationFrom { get; set; }
        public string DurationTo { get; set; }

        // Navigation Properties
        public CompanyModel Company { get; set; }
        public SalaryTypeModel SalaryType { get; set; }
    }
}