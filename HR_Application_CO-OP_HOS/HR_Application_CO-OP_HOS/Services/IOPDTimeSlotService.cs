using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IOPDTimeSlotService
    {
        IEnumerable<OPDTimeSlot> GetAll();
        OPDTimeSlot Get(int id);
        void Create(OPDTimeSlot OPDTimeSlot);
        void Update(OPDTimeSlot OPDTimeSlot);
        void Delete(int id);
    }
}