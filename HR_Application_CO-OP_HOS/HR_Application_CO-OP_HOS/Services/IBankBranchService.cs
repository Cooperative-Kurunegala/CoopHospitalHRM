using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBankBranchService
    {
        IEnumerable<BankBranch> GetAll();
        BankBranch Get(int id);
        void Create(BankBranch bankBranch);
        void Update(BankBranch bankBranch);
        void Delete(int id);
    }
}