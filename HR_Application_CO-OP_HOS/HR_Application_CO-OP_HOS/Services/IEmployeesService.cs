using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeesService
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        void Create(Employee Employee);
        void Update(Employee Employee);
        void Delete(int id);
    }
}