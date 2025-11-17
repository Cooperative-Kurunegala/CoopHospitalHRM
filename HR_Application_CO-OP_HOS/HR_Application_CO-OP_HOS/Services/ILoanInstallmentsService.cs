using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILoanInstallmentsService
    {
        IEnumerable<LoanInstallment> GetAll();
        LoanInstallment Get(int id);
        void Create(LoanInstallment LoanInstallment);
        void Update(LoanInstallment LoanInstallment);
        void Delete(int id);
    }
}