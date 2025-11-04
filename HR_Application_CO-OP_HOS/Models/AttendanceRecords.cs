using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("AttendanceRecords")]
    public class AttendanceRecords
    {
        [Key] public int ID { get; set; }
        public int? EPFNo { get; set; }
        public DateTime? AttendanceDateTime { get; set; }
        public bool? IsProcessed { get; set; }
        public int? CompanyID { get; set; }
    }
}