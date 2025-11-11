using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChargeMasterPriceService
    {
        IEnumerable<ChargeMasterPrice> GetAll();
        ChargeMasterPrice Get(int id);
        void Create(ChargeMasterPrice chargeMasterPrice);
        void Update(ChargeMasterPrice chargeMasterPrice);
        void Delete(int id);
    }
}