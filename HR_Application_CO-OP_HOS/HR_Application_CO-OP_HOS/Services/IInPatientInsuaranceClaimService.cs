using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IInPatientInsuaranceClaimService
    {
        IEnumerable<InPatientInsuranceClaim> GetAll();
        InPatientInsuranceClaim Get(int id);
        void Create(InPatientInsuranceClaim inPatientInsuaranceClaim);
        void Update(InPatientInsuranceClaim inPatientInsuaranceClaim);
        void Delete(int id);
    }
}