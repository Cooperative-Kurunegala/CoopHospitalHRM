using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("LeaveStatus")]
    public class LeaveStatus
    {
        [Key] public int ID { get; set; }
        [StringLength(50)] public string DayStatusDescription { get; set; }
        public int? OrderIndex { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal")] public decimal? LeaveCount { get; set; }
    }
}