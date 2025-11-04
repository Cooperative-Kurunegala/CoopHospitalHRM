using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("UnitType")]
    public class UnitType
    {
        [Key] public int ID { get; set; }
        [StringLength(500)] public string Name { get; set; }
        [StringLength(1000)] public string Description { get; set; }
        public bool? IsBoxItem { get; set; }
        [StringLength(50)] public string UnitTypeCode { get; set; }
    }

}