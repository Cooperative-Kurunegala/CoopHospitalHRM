using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("ChargeType")]
    public class ChargeType
    {
        [Key] public int ID { get; set; }
        [StringLength(100)] public string ChargeTypeName { get; set; }
        public virtual ICollection<ChargeCategory> ChargeCategories { get; set; } = new HashSet<ChargeCategory>();
        public virtual ICollection<DivisionCharge> DivisionCharges { get; set; } = new HashSet<DivisionCharge>();
    }
}