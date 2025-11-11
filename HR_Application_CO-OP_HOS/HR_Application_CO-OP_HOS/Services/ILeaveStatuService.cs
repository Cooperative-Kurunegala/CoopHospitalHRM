using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILeaveStatuService
    {
        IEnumerable<LeaveStatu> GetAll();
        LeaveStatu Get(int id);
        void Create(LeaveStatu LeaveStatu);
        void Update(LeaveStatu LeaveStatu);
        void Delete(int id);
    }
}