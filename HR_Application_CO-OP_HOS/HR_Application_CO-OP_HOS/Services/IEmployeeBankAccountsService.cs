using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeBankAccountsService
    {
        IEnumerable<EmployeeBankAccount> GetAll();
        EmployeeBankAccount Get(int id);
        void Create(EmployeeBankAccount EmployeeBankAccount);
        void Update(EmployeeBankAccount EmployeeBankAccount);
        void Delete(int id);
    }
}