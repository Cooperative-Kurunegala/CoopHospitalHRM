using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDoctorDivisionChargeMappingService
    {
        IEnumerable<DoctorDivisionChargeMapping> GetAll();
        DoctorDivisionChargeMapping Get(int id);
        void Create(DoctorDivisionChargeMapping doctorDivisionChargeMapping);
        void Update(DoctorDivisionChargeMapping doctorDivisionChargeMapping);
        void Delete(int id);
    }
}