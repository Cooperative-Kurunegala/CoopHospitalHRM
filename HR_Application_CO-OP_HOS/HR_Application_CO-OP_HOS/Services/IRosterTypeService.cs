using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRosterTypeService
    {
        IEnumerable<RosterType> GetAll();
        RosterType Get(int id);
        void Create(RosterType RosterType);
        void Update(RosterType RosterType);
        void Delete(int id);
    }
}