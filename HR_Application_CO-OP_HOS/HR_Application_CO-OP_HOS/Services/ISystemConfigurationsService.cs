using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISystemConfigurationsService
    {
        IEnumerable<SystemConfiguration> GetAll();
        SystemConfiguration Get(int id);
        void Create(SystemConfiguration SystemConfiguration);
        void Update(SystemConfiguration SystemConfiguration);
        void Delete(int id);
    }
}