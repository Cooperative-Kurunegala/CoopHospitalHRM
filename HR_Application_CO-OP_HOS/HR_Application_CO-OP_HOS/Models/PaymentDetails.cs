using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("PaymentDetails")]
    public class PaymentDetails
    {
        [Key] public int ID { get; set; }
        public int? ChargeItemListID { get; set; }
        public int? AdmissionType { get; set; }

        // keep the varchar OrderNo for reports/compatibility, *and* an OrderID FK for strong relationship
        [StringLength(50)] public string OrderNo { get; set; }
        public int? OrderID { get; set; }

        [Column(TypeName = "decimal")] public decimal? Amount { get; set; }
        public int? Drawer { get; set; }
        public int? DoctorID { get; set; }
        [StringLength(1000)] public string PatientName { get; set; }
        [StringLength(50)] public string BHT { get; set; }
        [Column(TypeName = "decimal")] public decimal? DoctorCharge { get; set; }
        [Column(TypeName = "decimal")] public decimal? HospitalCharge { get; set; }
        [StringLength(1000)] public string Reason { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? OrderStatus { get; set; }
        [StringLength(1000)] public string ReceivedBy { get; set; }
        public string Description { get; set; }
        public int? IsPosted { get; set; }
        public int? IsCancelPosted { get; set; }

        [ForeignKey("OrderID")] public virtual RelatedPartyOrder RelatedOrder { get; set; }
    }
}