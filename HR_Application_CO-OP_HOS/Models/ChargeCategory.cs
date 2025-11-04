using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("ChargeCategory")]
    public class ChargeCategory
    {
        [Key] public int ID { get; set; }
        [StringLength(200)] public string CategoryName { get; set; }
        [StringLength(1000)] public string CategoryDescription { get; set; }
        public int? ChargeTypeID { get; set; }

        [ForeignKey("ChargeTypeID")] public virtual ChargeType ChargeType { get; set; }
        public virtual ICollection<ChargeMaster> ChargeMasters { get; set; } = new HashSet<ChargeMaster>();
    }
}