using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISpecializationsService
    {
        IEnumerable<Specialization> GetAll();
        Specialization Get(int id);
        void Create(Specialization Specialization);
        void Update(Specialization Specialization);
        void Delete(int id);
    }
}