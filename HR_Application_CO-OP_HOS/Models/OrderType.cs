using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("OrderType")]
    public class OrderType
    {
        [Key] public int ID { get; set; }
        [StringLength(1000)] public string OrderTypeName { get; set; }
        public decimal? OrderSequence { get; set; }
        [StringLength(50)] public string OrderTypeCode { get; set; }
    }
}