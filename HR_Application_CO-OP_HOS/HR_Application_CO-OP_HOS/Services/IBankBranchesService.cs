using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBankBranchesService
    {
        IEnumerable<BankBranch> GetAll();
        BankBranch Get(int id);
        void Create(BankBranch BankBranche);
        void Update(BankBranch BankBranche);
        void Delete(int id);
    }
}