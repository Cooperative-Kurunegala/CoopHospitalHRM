using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILeaveService
    {
        IEnumerable<Leave> GetAll();
        Leave Get(int id);
        void Create(Leave Leave);
        void Update(Leave Leave);
        void Delete(int id);
    }
}