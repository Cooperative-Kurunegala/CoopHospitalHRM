using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeQualificationsService
    {
        IEnumerable<EmployeeQualification> GetAll();
        EmployeeQualification Get(int id);
        void Create(EmployeeQualification EmployeeQualification);
        void Update(EmployeeQualification EmployeeQualification);
        void Delete(int id);
    }
}