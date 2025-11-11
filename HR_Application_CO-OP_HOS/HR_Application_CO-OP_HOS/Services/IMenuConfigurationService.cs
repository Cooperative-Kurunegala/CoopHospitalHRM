using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IMenuConfigurationService
    {
        IEnumerable<MenuConfiguration> GetAll();
        MenuConfiguration Get(int id);
        void Create(MenuConfiguration MenuConfiguration);
        void Update(MenuConfiguration MenuConfiguration);
        void Delete(int id);
    }
}