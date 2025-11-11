using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IPayMonthMasterService
    {
        IEnumerable<PayMonthMaster> GetAll();
        PayMonthMaster Get(int id);
        void Create(PayMonthMaster PayMonthMaster);
        void Update(PayMonthMaster PayMonthMaster);
        void Delete(int id);
    }
}