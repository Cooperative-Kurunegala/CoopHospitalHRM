using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("CurrentPayrollMonth")]
    public class CurrentPayrollMonth
    {
        [Key] public int ID { get; set; }
        public int? CurrentPayrollMonthValue { get; set; }
        public int? CurrentPayrollYearValue { get; set; }
        public int? SalaryTypeID { get; set; }
        public int? CompanyID { get; set; }
        public bool? IsCurrentPayrollMonth { get; set; }
        [StringLength(50)] public string MonthName { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? DurationFrom { get; set; }
        public DateTime? DurationTo { get; set; }
    }
}