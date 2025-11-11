using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IOTTypeService
    {
        IEnumerable<OTType> GetAll();
        OTType Get(int id);
        void Create(OTType OTType);
        void Update(OTType OTType);
        void Delete(int id);
    }
}