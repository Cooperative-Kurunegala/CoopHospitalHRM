using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("BillFinalization")]
    public class BillFinalization
    {
        [Key] public int ID { get; set; }
        public int? AppSettingDetailID { get; set; }
        public int? RelatedPartySessionID { get; set; }
        [StringLength(500)] public string ChargeName { get; set; }
        [Column(TypeName = "decimal")] public decimal? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsPerHour { get; set; }
        public bool? IsMinimumFor24Hours { get; set; }
        [Column(TypeName = "decimal")] public decimal? PerDayValue { get; set; }
        [Column(TypeName = "decimal")] public decimal? NoOfHours { get; set; }
        public bool? IsPercentage { get; set; }
        public int? DivisionMasterTypeID { get; set; }
        public int? RelatedPartyOrderID { get; set; }
        public bool? IsThisBillIncentive { get; set; }
        public DateTime? SnapShotDateTime { get; set; }
        public int? ConsultantID { get; set; }
        [ForeignKey("RelatedPartyOrderID")] public virtual RelatedPartyOrder Order { get; set; }
    }
}