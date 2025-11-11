using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRosterStatuService
    {
        IEnumerable<RosterStatu> GetAll();
        RosterStatu Get(int id);
        void Create(RosterStatu RosterStatu);
        void Update(RosterStatu RosterStatu);
        void Delete(int id);
    }
}