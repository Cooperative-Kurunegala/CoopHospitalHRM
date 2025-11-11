using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISalaryModifierTypeService
    {
        IEnumerable<SalaryModifierType> GetAll();
        SalaryModifierType Get(int id);
        void Create(SalaryModifierType SalaryModifierType);
        void Update(SalaryModifierType SalaryModifierType);
        void Delete(int id);
    }
}