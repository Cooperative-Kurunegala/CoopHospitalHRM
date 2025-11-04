using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartySalaryBankAccountsMapping")]
    public class RelatedPartySalaryBankAccountsMapping
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyID { get; set; }
        public bool? IsEnabled { get; set; }
        [Column(TypeName = "decimal")] public decimal? DepositAmount { get; set; }
        public int? RelatedPartySalaryID { get; set; }
        public int? RelatedPartyBankAccountID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }

}