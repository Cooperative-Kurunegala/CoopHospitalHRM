using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAllowancesService
    {
        IEnumerable<Allowance> GetAll();
        Allowance Get(int id);
        void Create(Allowance allowance);
        void Update(Allowance allowance);
        void Delete(int id);
    }
}