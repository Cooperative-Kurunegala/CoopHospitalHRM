using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartyBankAccounts")]
    public class RelatedPartyBankAccount
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyID { get; set; }
        public int? BankID { get; set; }
        public int? BranchID { get; set; }
        [Column(TypeName = "decimal")] public decimal? StandingOrderAmount { get; set; }
        [StringLength(50)] public string BankAccountNo { get; set; }
        public bool? IsEnable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }

        [ForeignKey("RelatedPartyID")] public virtual EmployeeModel Employee { get; set; }
        [ForeignKey("BankID")] public virtual Bank Bank { get; set; }
        [ForeignKey("BranchID")] public virtual BankBranch BankBranch { get; set; }
    }

}