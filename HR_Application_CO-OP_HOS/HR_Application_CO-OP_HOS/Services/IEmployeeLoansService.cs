using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeLoansService
    {
        IEnumerable<EmployeeLoan> GetAll();
        EmployeeLoan Get(int id);
        void Create(EmployeeLoan EmployeeLoan);
        void Update(EmployeeLoan EmployeeLoan);
        void Delete(int id);
    }
}