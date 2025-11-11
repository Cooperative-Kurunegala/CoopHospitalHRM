using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IUnitTypeService
    {
        IEnumerable<UnitType> GetAll();
        UnitType Get(int id);
        void Create(UnitType UnitType);
        void Update(UnitType UnitType);
        void Delete(int id);
    }
}