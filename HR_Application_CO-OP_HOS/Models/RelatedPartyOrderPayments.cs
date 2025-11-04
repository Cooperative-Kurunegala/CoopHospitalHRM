using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartyOrderPayments")]
    public class RelatedPartyOrderPayments
    {
        [Key] public int ID { get; set; }
        public int? PaymentTypeID { get; set; }
        [Column(TypeName = "decimal")] public decimal? PaymentAmount { get; set; }
        public int? OrderID { get; set; }
        [StringLength(50)] public string CreditCardNumber { get; set; }
        [StringLength(50)] public string MCashCode { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        [Column(TypeName = "decimal")] public decimal? Balance { get; set; }
        public int? CreditCardTypeID { get; set; }
        public DateTime? CreditCardExpiryDate { get; set; }
        [StringLength(50)] public string ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        public bool? IsAccountsRecommended { get; set; }
        [StringLength(50)] public string RecommendedComment { get; set; }
        public int? RecommendedUserID { get; set; }
        public int? AdmissionID { get; set; }

        [ForeignKey("OrderID")] public virtual RelatedPartyOrder Order { get; set; }
        [ForeignKey("PaymentTypeID")] public virtual PaymentType PaymentType { get; set; }
        [ForeignKey("CreditCardTypeID")] public virtual CreditCardType CreditCardType { get; set; }
    }
}