using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("ChargeMasterPrice")]
    public class ChargeMasterPrice
    {
        [Key] public int ID { get; set; }
        public int? ChargeMasterID { get; set; }
        [StringLength(100)] public string Name { get; set; }
        [StringLength(1000)] public string Description { get; set; }
        public bool? IsDefault { get; set; }
        public int? OrderTypeID { get; set; }
        [Column(TypeName = "decimal")] public decimal? CostPrice { get; set; }
        [Column(TypeName = "decimal")] public decimal? Margin { get; set; }
        [Column(TypeName = "decimal")] public decimal? SellingPrice { get; set; }
        public int? RefDivisionMasterID { get; set; }

        [ForeignKey("ChargeMasterID")] public virtual ChargeMaster ChargeMaster { get; set; }
    }
}