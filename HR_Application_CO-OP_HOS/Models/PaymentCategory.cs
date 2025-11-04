using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("PaymentCategory")]
    public class PaymentCategory
    {
        [Key] public int ID { get; set; }
        public string CategoryName { get; set; }
        public int? OrderTypeID { get; set; }
        public virtual ICollection<RelatedPartyOrder> Orders { get; set; } = new HashSet<RelatedPartyOrder>();
    }
}