using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartySalaryModifierMapping")]
    public class SalaryModifierMapping
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartySalaryID { get; set; }
        public int? SalaryModifierID { get; set; }
        public int? OrderIndex { get; set; }
        [StringLength(50)] public string GroupingForSlip { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string ActualAmount { get; set; } // SQL used varchar(max), keep string but convert safely in app
        [StringLength(100)] public string SalaryModifierName { get; set; }
        public int? SalaryModifierTypeID { get; set; }
        public bool? IsNoPay { get; set; }
        public bool? IsLateHours { get; set; }
        public int? TaxTypeID { get; set; }
        public int? OTTypeID { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsAllawance { get; set; }
        public bool? IsRemoved { get; set; }
        public bool? IsLoan { get; set; }

        [ForeignKey("RelatedPartySalaryID")] public virtual SalaryModel Salary { get; set; }
        [ForeignKey("SalaryModifierID")] public virtual SalaryModifier SalaryModifier { get; set; }
    }
}