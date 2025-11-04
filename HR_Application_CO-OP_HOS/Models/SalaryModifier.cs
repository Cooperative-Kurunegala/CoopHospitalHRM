using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("SalaryModifiers")]
    public class SalaryModifier
    {
        [Key] public int ID { get; set; }
        [StringLength(100)] public string SalaryModifierName { get; set; }
        public int? SalaryModifierTypeID { get; set; }
        public bool? IsNoPay { get; set; }
        public bool? IsLateHours { get; set; }
        public int? TaxTypeID { get; set; }
        public bool? IsEnabled { get; set; }
        public int? OrderIndex { get; set; }
        public int? OTTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsBasicSalary { get; set; }
        public bool? IsAllawance { get; set; }
        public bool? IsEditable { get; set; }
        public int? PreviousSalaryModifierID { get; set; }
    }

}