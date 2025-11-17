using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IDepartmentsService
    {
        IEnumerable<Department> GetAll();
        Department Get(int id);
        void Create(Department Department);
        void Update(Department Department);
        void Delete(int id);
    }
}