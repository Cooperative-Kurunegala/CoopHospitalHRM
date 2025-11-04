using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("AttendanceTime")]
    public class AttendanceTime
    {
        [Key] public int ID { get; set; }
        public TimeSpan? AttendanceFromTime { get; set; }
        public TimeSpan? AttendanceToTime { get; set; }
    }
}