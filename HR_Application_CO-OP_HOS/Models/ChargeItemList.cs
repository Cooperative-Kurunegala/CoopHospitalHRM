using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("ChargeItemList")]
    public class ChargeItemList
    {
        [Key] public int ID { get; set; }
        [StringLength(50)] public string Name { get; set; }
        public int? Type { get; set; }
    }
}