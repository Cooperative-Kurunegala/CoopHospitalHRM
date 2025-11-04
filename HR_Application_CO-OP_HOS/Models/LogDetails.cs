using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("LogDetails")]
    public class LogDetails
    {
        [Key] public int id { get; set; }
        public DateTime? log_date { get; set; }
        public int? usr_sys_code { get; set; }
        public int? RelatedID { get; set; }
        [StringLength(50)] public string RelatedTable { get; set; }
        [StringLength(50)] public string log_desc { get; set; }
        [StringLength(50)] public string log_event { get; set; }
    }
}