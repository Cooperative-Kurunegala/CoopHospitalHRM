using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISalaryModifierDefaultValueService
    {
        IEnumerable<SalaryModifierDefaultValue> GetAll();
        SalaryModifierDefaultValue Get(int id);
        void Create(SalaryModifierDefaultValue SalaryModifierDefaultValue);
        void Update(SalaryModifierDefaultValue SalaryModifierDefaultValue);
        void Delete(int id);
    }
}