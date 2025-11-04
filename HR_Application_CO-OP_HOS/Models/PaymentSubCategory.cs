using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("PaymentSubCategory")]
    public class PaymentSubCategory
    {
        [Key] public int ID { get; set; }
        public string CategoryName { get; set; }
        public int? OrderTypeID { get; set; }
    }
}