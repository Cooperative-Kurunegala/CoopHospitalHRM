using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("BankBranches")]
    public class BankBranch
    {
        [Key] public int ID { get; set; }
        [StringLength(500)] public string BranchName { get; set; }
        public int? BankID { get; set; }
        [StringLength(50)] public string BranchCode { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        [ForeignKey("BankID")] public virtual Bank Bank { get; set; }
    }
}