using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("AppSettings")]
    public class AppSettings
    {
        [Key] public int ID { get; set; }
        [StringLength(50)] public string AppSettingKey { get; set; }
        [StringLength(500)] public string AppSettingValue { get; set; }
        public virtual ICollection<AppSettingsDetail> Details { get; set; } = new HashSet<AppSettingsDetail>();
    }
}