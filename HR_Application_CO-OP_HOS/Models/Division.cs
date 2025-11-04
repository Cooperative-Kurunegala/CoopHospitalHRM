using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("DivisionMaster")]
    public class Division
    {
        [Key] public int ID { get; set; }
        [StringLength(100)] public string DivisionMasterName { get; set; }
        [StringLength(100)] public string DivisionMasterCode { get; set; }
        public bool? IsActive { get; set; }
        public int? MenuTypeID { get; set; }
        public int? MenuTypeDetailID { get; set; }
        [StringLength(1000)] public string DivisionMasterDescription { get; set; }
        public bool? IsStockManaged { get; set; }
        public int? ParentDivisionMasterID { get; set; }
        public int? DivisionMasterTypeID { get; set; }
        public int? LocationID { get; set; }
        public int? OrderTypeID { get; set; }
        public decimal? OrderSequence { get; set; }

        public virtual ICollection<DivisionCharge> DivisionCharges { get; set; } = new HashSet<DivisionCharge>();
        public virtual ICollection<RelatedPartyOrder> Orders { get; set; } = new HashSet<RelatedPartyOrder>();
    }
}