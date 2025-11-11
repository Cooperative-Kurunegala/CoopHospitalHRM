using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChargeMasterService
    {
        IEnumerable<ChargeMaster> GetAll();
        ChargeMaster Get(int id);
        void Create(ChargeMaster chargeMaster);
        void Update(ChargeMaster chargeMaster);
        void Delete(int id);
    }
}