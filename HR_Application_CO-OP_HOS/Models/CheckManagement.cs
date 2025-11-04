using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("CheckManagment")]
    public class CheckManagment
    {
        [Key] public int ID { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? PostDate { get; set; }
        public string InvoiceNo { get; set; }
        [StringLength(50)] public string CheckNumber { get; set; }
        public int? RelatedpartyID { get; set; }
        [Column(TypeName = "decimal")] public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DivisionMasterID { get; set; }
        public int? PaymentCategoryID { get; set; }
        public int? ChequeType { get; set; }
        public int? IsIssued { get; set; }
        public int? OrderStatus { get; set; }
        public DateTime? IssueDateTime { get; set; }
    }
}