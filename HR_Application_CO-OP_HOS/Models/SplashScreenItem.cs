using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("SplashScreenItem")]
    public class SplashScreenItem
    {
        [Key] public int ID { get; set; }
        [StringLength(100)] public string SplashScreenItemName { get; set; }
        [StringLength(1000)] public string SplashScreenItemDescription { get; set; }
        public int? OrderIndex { get; set; }
        public int? AttachmentID { get; set; }
        public int? LocationID { get; set; }

        [ForeignKey("LocationID")] public virtual Location Location { get; set; }
    }
}