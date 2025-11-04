using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("ChargeMaster")]
    public class ChargeMaster
    {
        [Key] public int ID { get; set; }
        [StringLength(500)] public string Name { get; set; }
        [StringLength(1000)] public string Description { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)] public string Code { get; set; }
        public int? UnitTypeID { get; set; }
        public int? MenuTypeID { get; set; }
        public int? MenuTypeDetailID { get; set; }
        public int? ChargeTypeID { get; set; }
        public int? ChargeCategoryID { get; set; }
        public int? LocationID { get; set; }
        public bool? IsIncentiveCalculate { get; set; }

        [ForeignKey("ChargeCategoryID")] public virtual ChargeCategory ChargeCategory { get; set; }
        [ForeignKey("ChargeTypeID")] public virtual ChargeType ChargeType { get; set; }
        public virtual ICollection<ChargeMasterPrice> Prices { get; set; } = new HashSet<ChargeMasterPrice>();
        public virtual ICollection<DivisionCharge> DivisionCharges { get; set; } = new HashSet<DivisionCharge>();
    }
}