using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("Bank")]
    public class Bank
    {
        [Key] public int ID { get; set; }
        [StringLength(500)] public string BankName { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}