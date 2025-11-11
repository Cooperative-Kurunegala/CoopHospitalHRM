using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILeaveTypeService
    {
        IEnumerable<LeaveType> GetAll();
        LeaveType Get(int id);
        void Create(LeaveType LeaveType);
        void Update(LeaveType LeaveType);
        void Delete(int id);
    }
}