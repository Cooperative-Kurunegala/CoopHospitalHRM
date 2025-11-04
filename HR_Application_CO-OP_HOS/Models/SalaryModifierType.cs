using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("SalaryModifierTypes")]
    public class SalaryModifierType
    {
        [Key] public int ID { get; set; }
        [StringLength(100)] public string SalaryModifierTypeName { get; set; }
        public int? Type { get; set; }
    }
}