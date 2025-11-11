using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILocationService
    {
        IEnumerable<Location> GetAll();
        Location Get(int id);
        void Create(Location Location);
        void Update(Location Location);
        void Delete(int id);
    }
}