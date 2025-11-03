using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Province { get; set; }
        public string EmployeeType { get; set; }
        public string NICNumber { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string EPFNumber { get; set; }
        public string ETFNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactAddress { get; set; }
        public string JoinedDate { get; set; }

        // Foreign Keys
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int GradeId { get; set; }
        public int CompanyId { get; set; }

        // Navigation Properties (1-to-Many)
        public DepartmentModel Department { get; set; }
        public DesignationModel Designation { get; set; }
        public GradeModel Grade { get; set; }
        public CompanyModel Company { get; set; }

        // Collections (1-to-Many)
        public List<EmployeeBenefitModel> EmployeeBenefits { get; set; }
        public List<AttendanceModel> Attendances { get; set; }
        public List<SalaryModel> Salaries { get; set; }
        public List<RelatedPartySessionModel> Sessions { get; set; }
    }

}