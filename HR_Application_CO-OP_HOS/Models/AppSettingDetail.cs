using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("AppSettingsDetail")]
    public class AppSettingsDetail
    {
        [Key] public int ID { get; set; }
        [StringLength(50)] public string AppSettingsDetailKey { get; set; }
        [StringLength(500)] public string AppSettingDetailValue { get; set; }
        public int? AppSettingsID { get; set; }
        public bool? IsPerHour { get; set; }
        public bool? IsMinimumFor24Hours { get; set; }
        public bool? IsPercentage { get; set; }
        public int? DivisionMasterTypeID { get; set; }
        public int? RelatedPartyOrderID { get; set; }

        [ForeignKey("AppSettingsID")] public virtual AppSettings AppSettings { get; set; }
    }
}