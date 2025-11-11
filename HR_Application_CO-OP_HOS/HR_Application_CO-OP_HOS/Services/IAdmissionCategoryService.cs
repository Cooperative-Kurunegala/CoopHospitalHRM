using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAdmissionCategoryService
    {
        IEnumerable<AdmissionCategory> GetAll();
        AdmissionCategory Get(int id);
        void Create(AdmissionCategory ac);
        void Update(AdmissionCategory ac);
        void Delete(int id);
    } 
}