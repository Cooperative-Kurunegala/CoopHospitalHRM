using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeTypesService
    {
        IEnumerable<EmployeeType> GetAll();
        EmployeeType Get(int id);
        void Create(EmployeeType EmployeeType);
        void Update(EmployeeType EmployeeType);
        void Delete(int id);
    }
}