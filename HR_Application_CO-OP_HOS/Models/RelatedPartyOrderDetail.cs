using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartyOrderDetail")]
    public class RelatedPartyOrderDetail
    {
        [Key] public int ID { get; set; }
        public int? OrderID { get; set; }
        [Column(TypeName = "decimal")] public decimal? Qty { get; set; }
        [Column(TypeName = "decimal")] public decimal? Price { get; set; }
        [Column(TypeName = "decimal")] public decimal? LineTotal { get; set; }
        public int? DivisionChargeID { get; set; }
        [StringLength(100)] public string DivisionChargeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? ChargeTypeID { get; set; }
        [StringLength(50)] public string BatchNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "decimal")] public decimal? ReorderLevel { get; set; }
        public int? ChargeMasterPriceID { get; set; }
        public bool? IsNurseCharge { get; set; }
        [Column(TypeName = "decimal")] public decimal? BonusQty { get; set; }
        [Column(TypeName = "decimal")] public decimal? DocFee { get; set; }
        [Column(TypeName = "decimal")] public decimal? HosFee { get; set; }
        [Column(TypeName = "decimal")] public decimal? WardDocFee { get; set; }
        public int? BatchPopupID { get; set; }
        public bool? IsNightTest { get; set; }
        public int? involvedperson { get; set; }
        [Column(TypeName = "decimal")] public decimal? QtyPerPack { get; set; }
        [Column(TypeName = "decimal")] public decimal? SalesPrice { get; set; }
        [Column(TypeName = "decimal")] public decimal? TechnicianCharge { get; set; }
        public int? AttachmentID { get; set; }
        [Column(TypeName = "decimal")] public decimal? NurseFee { get; set; }

        [ForeignKey("OrderID")] public virtual RelatedPartyOrder Order { get; set; }
        [ForeignKey("DivisionChargeID")] public virtual DivisionCharge DivisionCharge { get; set; }
    }

}