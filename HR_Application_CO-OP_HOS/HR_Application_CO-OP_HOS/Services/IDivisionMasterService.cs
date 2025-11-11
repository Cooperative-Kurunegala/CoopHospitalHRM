using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDivisionMasterService
    {
        IEnumerable<DivisionMaster> GetAll();
        DivisionMaster Get(int id);
        void Create(DivisionMaster divisionMaster);
        void Update(DivisionMaster divisionMaster);
        void Delete(int id);
    }
}