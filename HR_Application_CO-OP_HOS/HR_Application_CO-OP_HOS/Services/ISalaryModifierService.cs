using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISalaryModifierService
    {
        IEnumerable<SalaryModifier> GetAll();
        SalaryModifier Get(int id);
        void Create(SalaryModifier SalaryModifier);
        void Update(SalaryModifier SalaryModifier);
        void Delete(int id);
    }
}