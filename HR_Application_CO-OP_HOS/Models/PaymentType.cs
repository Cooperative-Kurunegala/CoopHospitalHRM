using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("PaymentType")]
    public class PaymentType
    {
        [Key] public int ID { get; set; }
        [StringLength(200)] public string PaymentTypeName { get; set; }
        public int? PaymentTypeCode { get; set; }
        public virtual ICollection<RelatedPartyOrderPayments> OrderPayments { get; set; } = new HashSet<RelatedPartyOrderPayments>();
    }
}