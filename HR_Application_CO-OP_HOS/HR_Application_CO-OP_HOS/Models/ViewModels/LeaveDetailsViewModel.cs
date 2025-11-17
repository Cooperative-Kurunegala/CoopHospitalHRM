namespace HR_Application_CO_OP_HOS.Models.ViewModels
{
    using System;

    public class LeaveDetailsViewModel
    {
        public int LeaveID { get; set; }

        // Related display values
        public string EmployeeFullName { get; set; }
        public string LeaveTypeName { get; set; }
        public string LeaveCategoryName { get; set; }

        // Leaf properties
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalDays { get; set; }
        public bool MedicalCertificate { get; set; }
        public string CertificatePath { get; set; }
        public string Reason { get; set; }
        public string RejectionReason { get; set; }

        // Approval / creation info
        public string ApprovedByFullName { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByFullName { get; set; }
    }
}