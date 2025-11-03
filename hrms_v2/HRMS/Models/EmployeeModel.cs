using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRMS.Models.Enum;

namespace HRMS.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        //Enum Using
        public ReligionEnum Religion { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
        public GenderEnum Gender { get; set; }
        public ProvinceEnum Province { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
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
        public DateTime JoinedDate { get; set; }

        //Foreign Keys Adding
        //Department Model
        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
        //Designation Model
        public int DesignationId { get; set; }
        public DesignationModel Designation { get; set; }
        //Grade Model
        public int GradeId { get; set; }
        public GradeModel Grade { get; set; }
        //Company Model
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
        //Benefit Model
        public int EmployeeBenefitId { get; set; }
        public virtual ICollection<EmployeeBenefitModel> EmployeeBenefits { get; set; }
        public ICollection<AttendanceModel> Attendances { get; set; }
    }
}