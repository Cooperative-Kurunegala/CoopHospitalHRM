using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IPayrollRecordsService
    {
        IEnumerable<PayrollRecord> GetAll();
        PayrollRecord Get(int id);
        void Create(PayrollRecord PayrollRecord);
        void Update(PayrollRecord PayrollRecord);
        void Delete(int id);
    }
}