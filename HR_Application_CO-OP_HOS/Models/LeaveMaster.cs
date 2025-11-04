using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("LeaveMaster")]
    public class LeaveMaster
    {
        [Key] public int ID { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public int? RecommendedBy { get; set; }
        public DateTime? RecommendedDateTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LeaveFrom { get; set; }
        public DateTime? LeaveTo { get; set; }
        [Column(TypeName = "decimal")] public decimal? NoOfLeaves { get; set; }
        public int? RelatedPartyID { get; set; }
        public DateTime? LeaveDate { get; set; }

        [ForeignKey("RelatedPartyID")] public virtual EmployeeModel Employee { get; set; }
    }
}