using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("BatchPopup")]
    public class BatchPopup
    {
        [Key] public int ID { get; set; }
        public int? DivisionChargeID { get; set; }
        [StringLength(50)] public string BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "decimal")] public decimal? Stock { get; set; }
        public DateTime? OpeningStockDate { get; set; }
        [Column(TypeName = "decimal")] public decimal? OpeningStock { get; set; }
        [Column(TypeName = "decimal")] public decimal? BatchSellingPrice { get; set; }
        [Column(TypeName = "decimal")] public decimal? CostPrice { get; set; }
    }
}