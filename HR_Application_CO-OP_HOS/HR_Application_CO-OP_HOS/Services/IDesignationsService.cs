using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDesignationsService
    {
        IEnumerable<Designation> GetAll();
        Designation Get(int id);
        void Create(Designation Designation);
        void Update(Designation Designation);
        void Delete(int id);
    }
}