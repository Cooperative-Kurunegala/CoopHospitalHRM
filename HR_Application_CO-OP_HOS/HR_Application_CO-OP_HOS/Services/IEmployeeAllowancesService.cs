using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeAllowancesService
    {
        IEnumerable<EmployeeAllowance> GetAll();
        EmployeeAllowance Get(int id);
        void Create(EmployeeAllowance EmployeeAllowance);
        void Update(EmployeeAllowance EmployeeAllowance);
        void Delete(int id);
    }
}