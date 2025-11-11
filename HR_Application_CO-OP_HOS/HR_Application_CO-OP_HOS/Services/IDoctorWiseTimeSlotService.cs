using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDoctorWiseTimeSlotService
    {
        IEnumerable<DoctorWiseTimeSlot> GetAll();
        DoctorWiseTimeSlot Get(int id);
        void Create(DoctorWiseTimeSlot doctorWiseTimeSlot);
        void Update(DoctorWiseTimeSlot doctorWiseTimeSlot);
        void Delete(int id);
    }
}