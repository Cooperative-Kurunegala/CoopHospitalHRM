using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBillFinalization_LastService
    {
        IEnumerable<BillFinalization_Last> GetAll();
        BillFinalization_Last Get(int id);
        void Create(BillFinalization_Last billFinalization_Last);
        void Update(BillFinalization_Last billFinalization_Last);
        void Delete(int id);
    }
}