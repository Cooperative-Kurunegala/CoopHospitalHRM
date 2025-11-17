using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeCategoriesService
    {
        IEnumerable<EmployeeCategory> GetAll();
        EmployeeCategory Get(int id);
        void Create(EmployeeCategory EmployeeCategory);
        void Update(EmployeeCategory EmployeeCategory);
        void Delete(int id);
    }
}