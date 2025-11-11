using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILeaveMasterService
    {
        IEnumerable<LeaveMaster> GetAll();
        LeaveMaster Get(int id);
        void Create(LeaveMaster LeaveMaster);
        void Update(LeaveMaster LeaveMaster);
        void Delete(int id);
    }
}