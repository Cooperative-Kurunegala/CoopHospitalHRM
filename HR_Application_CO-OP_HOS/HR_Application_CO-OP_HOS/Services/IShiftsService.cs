using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IShiftsService
    {
        IEnumerable<Shift> GetAll();
        Shift Get(int id);
        void Create(Shift Shift);
        void Update(Shift Shift);
        void Delete(int id);
    }
}