using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDivisionChargeService
    {
        IEnumerable<DivisionCharge> GetAll();
        DivisionCharge Get(int id);
        void Create(DivisionCharge divisionCharge);
        void Update(DivisionCharge divisionCharge);
        void Delete(int id);
    }
}