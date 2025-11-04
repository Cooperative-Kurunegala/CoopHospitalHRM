using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("LeaveType")]
    public class LeaveType
    {
        [Key] public int ID { get; set; }
        [StringLength(50)] public string TypeName { get; set; }
        public int? LeaveDuration { get; set; }
    }
}