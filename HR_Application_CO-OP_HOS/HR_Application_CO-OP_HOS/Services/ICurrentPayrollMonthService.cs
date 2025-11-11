using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ICurrentPayrollMonthService
    {
        IEnumerable<CurrentPayrollMonth> GetAll();
        CurrentPayrollMonth Get(int id);
        void Create(CurrentPayrollMonth currentPayrollMonth);
        void Update(CurrentPayrollMonth currentPayrollMonth);
        void Delete(int id);
    }
}