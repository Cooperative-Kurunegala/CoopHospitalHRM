using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDivisionMasterOrderTypeMappingService
    {
        IEnumerable<DivisionMasterOrderTypeMapping> GetAll();
        DivisionMasterOrderTypeMapping Get(int id);
        void Create(DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping);
        void Update(DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping);
        void Delete(int id);
    }
}