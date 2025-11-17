using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IEmployeeTrainingsService
    {
        IEnumerable<EmployeeTraining> GetAll();
        EmployeeTraining Get(int id);
        void Create(EmployeeTraining EmployeeTraining);
        void Update(EmployeeTraining EmployeeTraining);
        void Delete(int id);
    }
}