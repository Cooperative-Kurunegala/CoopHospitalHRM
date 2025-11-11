using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISalaryTypeService
    {
        IEnumerable<SalaryType> GetAll();
        SalaryType Get(int id);
        void Create(SalaryType SalaryType);
        void Update(SalaryType SalaryType);
        void Delete(int id);
    }
}