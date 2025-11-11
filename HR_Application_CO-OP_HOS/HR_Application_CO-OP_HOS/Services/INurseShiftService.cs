using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface INurseShiftService
    {
        IEnumerable<NurseShift> GetAll();
        NurseShift Get(int id);
        void Create(NurseShift NurseShift);
        void Update(NurseShift NurseShift);
        void Delete(int id);
    }
}