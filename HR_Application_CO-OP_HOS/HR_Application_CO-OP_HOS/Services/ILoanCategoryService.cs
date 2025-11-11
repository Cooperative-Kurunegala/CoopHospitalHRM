using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILoanCategoryService
    {
        IEnumerable<LoanCategory> GetAll();
        LoanCategory Get(int id);
        void Create(LoanCategory LoanCategory);
        void Update(LoanCategory LoanCategory);
        void Delete(int id);
    }
}