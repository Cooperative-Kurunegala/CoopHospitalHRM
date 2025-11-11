using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IOPDSquenceService
    {
        IEnumerable<OPDSquence> GetAll();
        OPDSquence Get(int id);
        void Create(OPDSquence OPDSquence);
        void Update(OPDSquence OPDSquence);
        void Delete(int id);
    }
}