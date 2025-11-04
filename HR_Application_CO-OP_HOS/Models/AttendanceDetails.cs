using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("AttendanceDetails")]
    public class AttendanceDetails
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyID { get; set; }
        public int? WorkedMonth { get; set; }
        public int? WorkedYear { get; set; }
        public bool? IsOTRecommended { get; set; }

        [ForeignKey("RelatedPartyID")] public virtual EmployeeModel Employee { get; set; }
    }
}