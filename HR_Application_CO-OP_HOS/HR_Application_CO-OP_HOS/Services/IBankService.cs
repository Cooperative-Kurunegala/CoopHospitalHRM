using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBankService
    {
        IEnumerable<Bank> GetAll();
        Bank Get(int id);
        void Create(Bank bank);
        void Update(Bank bank);
        void Delete(int id);
    }
}