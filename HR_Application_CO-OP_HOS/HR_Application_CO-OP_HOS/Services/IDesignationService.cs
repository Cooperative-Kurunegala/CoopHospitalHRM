using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDesignationService
    {
        IEnumerable<Designation> GetAll();
        Designation Get(int id);
        void Create(Designation designation);
        void Update(Designation designation);
        void Delete(int id);
    }
}