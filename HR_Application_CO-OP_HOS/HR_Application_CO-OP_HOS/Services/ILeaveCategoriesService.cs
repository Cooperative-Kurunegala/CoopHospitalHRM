using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILeaveCategoriesService
    {
        IEnumerable<LeaveCategory> GetAll();
        LeaveCategory Get(int id);
        void Create(LeaveCategory LeaveCategory);
        void Update(LeaveCategory LeaveCategory);
        void Delete(int id);
    }
}