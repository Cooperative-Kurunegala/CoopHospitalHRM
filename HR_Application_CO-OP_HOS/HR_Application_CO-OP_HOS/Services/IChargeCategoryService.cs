using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChargeCategoryService
    {
        IEnumerable<ChargeCategory> GetAll();
        ChargeCategory Get(int id);
        void Create(ChargeCategory chargeCategory);
        void Update(ChargeCategory chargeCategory);
        void Delete(int id);
    }
}