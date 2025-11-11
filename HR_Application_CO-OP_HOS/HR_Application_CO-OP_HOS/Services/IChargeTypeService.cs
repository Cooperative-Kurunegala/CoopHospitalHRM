using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChargeTypeService
    {
        IEnumerable<ChargeType> GetAll();
        ChargeType Get(int id);
        void Create(ChargeType chargeType);
        void Update(ChargeType chargeType);
        void Delete(int id);
    }
}