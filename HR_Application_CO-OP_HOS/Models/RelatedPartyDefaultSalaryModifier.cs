using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartyDefaultSalaryModifiers")]
    public class RelatedPartyDefaultSalaryModifier
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyID { get; set; }
        public int? SalaryModifierID { get; set; }
        public int? OrderIndex { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string DefaultValue { get; set; }
    }
}