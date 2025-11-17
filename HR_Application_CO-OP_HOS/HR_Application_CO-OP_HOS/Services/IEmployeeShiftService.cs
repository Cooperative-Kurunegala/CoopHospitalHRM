using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeShiftService
    {
        IEnumerable<EmployeeShift> GetAll();
        EmployeeShift Get(int id);
        void Create(EmployeeShift EmployeeShift);
        void Update(EmployeeShift EmployeeShift);
        void Delete(int id);
    }
}