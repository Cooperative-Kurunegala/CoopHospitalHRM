using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartySalary")]
    public class SalaryModel
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyEPF { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? CompanyID { get; set; }
        [Column(TypeName = "decimal")] public decimal? NoPayDays { get; set; }
        public int? LateMinutes { get; set; }
        public int? OTMinutes { get; set; }
        public int? RelatedPartyID { get; set; }
        public bool? IsPayoutGenerated { get; set; }
        public bool? IsLocked { get; set; }
        public int? SalaryTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }

        [ForeignKey("RelatedPartyID")] public virtual EmployeeModel Employee { get; set; }
        public virtual ICollection<SalaryModifierMapping> SalaryModifiers { get; set; } = new HashSet<SalaryModifierMapping>();
    }
}