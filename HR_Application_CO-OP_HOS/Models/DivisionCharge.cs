using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("DivisionCharge")]
    public class DivisionCharge
    {
        [Key] public int ID { get; set; }
        public int? ChargeMasterID { get; set; }
        public int? DivisionMasterID { get; set; }
        [Column(TypeName = "decimal")] public decimal? Qty { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public int? ChargeTypeID { get; set; }
        [StringLength(50)] public string BatchNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "decimal")] public decimal? ReorderLevel { get; set; }
        public int? ChargeMasterPriceID { get; set; }
        public int? LocationID { get; set; }
        public bool? IsBoxItem { get; set; }
        [Column(TypeName = "decimal")] public decimal? PerBoxQty { get; set; }
        [Column(TypeName = "decimal")] public decimal? CostPrice { get; set; }
        [Column(TypeName = "decimal")] public decimal? Margin { get; set; }
        [Column(TypeName = "decimal")] public decimal? SellingPrice { get; set; }
        [Column(TypeName = "decimal")] public decimal? WardPharmacyPrice { get; set; }
        public int? ParentDivisionChargeID { get; set; }
        public int? ConsultantID { get; set; }
        [Column(TypeName = "decimal")] public decimal? PhysicalStock { get; set; }
        [Column(TypeName = "decimal")] public decimal? OpeningStock { get; set; }
        public bool? IsIncentiveCalculate { get; set; }
        public int? AttachmentID { get; set; }

        [ForeignKey("DivisionMasterID")] public virtual Division DivisionMaster { get; set; }
        [ForeignKey("ChargeMasterID")] public virtual ChargeMaster ChargeMaster { get; set; }
        [ForeignKey("ChargeTypeID")] public virtual ChargeType ChargeType { get; set; }
    }
}