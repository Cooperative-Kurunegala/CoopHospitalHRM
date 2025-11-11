using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("PayMonthMaster")]
    public class PayMonth
    {
        [Key] public int ID { get; set; }
        public int? PayMonthValue { get; set; }
        public int? PayYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? isCurrentMonth { get; set; }
    }
}