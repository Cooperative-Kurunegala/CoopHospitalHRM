using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedPartyOrder")]
    public class RelatedPartyOrder
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyID { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderTypeID { get; set; }
        [StringLength(50)] public string OrderNo { get; set; } // original varchar reference
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte? OrderStatus { get; set; }
        public int? LocationID { get; set; }
        public int? ChargeDiscountID { get; set; }
        [StringLength(50)] public string RelatedPartyIdentityCardNo { get; set; }
        public int? InvolvedPerson { get; set; }
        public int? DivisionMasterID { get; set; }
        public bool? IsNightTest { get; set; }
        public int? AssignedPerson { get; set; }
        public int? AdmissionTypeID { get; set; }
        public bool? IsHomeVisit { get; set; }
        [Column(TypeName = "decimal")] public decimal? HomeVisitHospitalCharge { get; set; }
        public int? RefPurchaseOrderID { get; set; }
        public int? RelatedPartySessionID { get; set; }
        public bool? isSafeDeleted { get; set; }
        public bool? IsPosted { get; set; }
        public bool? IsCancelPosted { get; set; }
        public int? AccountingInvoiceID { get; set; }
        [StringLength(50)] public string AppointmentNo { get; set; }
        public int? ConsultantID { get; set; }
        public int? PaymentCategoryID { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        [Column(TypeName = "decimal")] public decimal? DiscountPercentage { get; set; }
        public int? PatientVisitID { get; set; }
        public int? TimeSlotID { get; set; }
        [StringLength(50)] public string Times { get; set; }
        [StringLength(50)] public string BHTNo { get; set; }
        public bool? IsConfirmed { get; set; }
        public int? RoomID { get; set; }
        public int? Drawer { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public int? ConfirmedBy { get; set; }
        public bool? isVerified { get; set; }
        public bool? isPaid { get; set; }
        public int? PaidBy { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? PaymentSubCategoryID { get; set; }

        [ForeignKey("RelatedPartyID")] public virtual EmployeeModel Employee { get; set; }
        [ForeignKey("DivisionMasterID")] public virtual Division Division { get; set; }

        public virtual ICollection<RelatedPartyOrderDetail> OrderDetails { get; set; } = new HashSet<RelatedPartyOrderDetail>();
        public virtual ICollection<RelatedPartyOrderPayments> Payments { get; set; } = new HashSet<RelatedPartyOrderPayments>();
        public virtual ICollection<PaymentDetails> PaymentDetails { get; set; } = new HashSet<PaymentDetails>();
    }
}