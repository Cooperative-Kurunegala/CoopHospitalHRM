using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IOnCallSchedulesService
    {
        IEnumerable<OnCallSchedule> GetAll();
        OnCallSchedule Get(int id);
        void Create(OnCallSchedule OnCallSchedule);
        void Update(OnCallSchedule OnCallSchedule);
        void Delete(int id);
    }
}