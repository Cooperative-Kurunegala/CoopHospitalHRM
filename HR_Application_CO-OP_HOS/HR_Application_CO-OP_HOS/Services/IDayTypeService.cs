using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDayTypeService
    {
        IEnumerable<DayType> GetAll();
        DayType Get(int id);
        void Create(DayType dayType);
        void Update(DayType dayType);
        void Delete(int id);
    }
}