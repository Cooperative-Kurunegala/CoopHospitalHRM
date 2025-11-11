using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBatchPopUpService
    {
        IEnumerable<BatchPopup> GetAll();
        BatchPopup Get(int id);
        void Create(BatchPopup batchPopup);
        void Update(BatchPopup batchPopup);
        void Delete(int id);
    }
}