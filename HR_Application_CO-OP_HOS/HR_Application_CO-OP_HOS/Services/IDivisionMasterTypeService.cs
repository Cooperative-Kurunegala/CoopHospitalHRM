using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDivisionMasterTypeService
    {
        IEnumerable<DivisionMasterType> GetAll();
        DivisionMasterType Get(int id);
        void Create(DivisionMasterType divisionMasterType);
        void Update(DivisionMasterType divisionMasterType);
        void Delete(int id);
    }
}