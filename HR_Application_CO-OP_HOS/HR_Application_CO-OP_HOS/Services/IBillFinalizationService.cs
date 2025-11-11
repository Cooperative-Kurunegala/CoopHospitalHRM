using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBillFinalizationService
    {
        IEnumerable<BillFinalization> GetAll();
        BillFinalization Get(int id);
        void Create(BillFinalization billFinalization);
        void Update(BillFinalization billFinalization);
        void Delete(int id);
    }
}