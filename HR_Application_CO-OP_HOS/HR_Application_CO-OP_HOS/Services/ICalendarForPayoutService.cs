using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ICalendarForPayoutService
    {
        IEnumerable<CalanderForPayout> GetAll();
        CalanderForPayout Get(int id);
        void Create(CalanderForPayout calanderForPayout);
        void Update(CalanderForPayout calanderForPayout);
        void Delete(int id);
    }
}