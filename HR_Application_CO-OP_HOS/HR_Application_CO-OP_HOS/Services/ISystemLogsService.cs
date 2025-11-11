using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISystemLogsService
    {
        IEnumerable<SystemLog> GetAll();
        SystemLog Get(int id);
        void Create(SystemLog SystemLog);
        void Update(SystemLog SystemLog);
        void Delete(int id);
    }
}