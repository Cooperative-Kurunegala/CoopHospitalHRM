using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAdmissionType
    {
        IEnumerable<AdmissionType> GetAll();
        AdmissionType Get(int id);
        void Create(AdmissionType admissionType);
        void Update(AdmissionType admissionType);
        void Delete(int id);
    }
}