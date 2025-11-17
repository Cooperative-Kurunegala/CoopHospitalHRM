using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IWardsService
    {
        IEnumerable<Ward> GetAll();
        Ward Get(int id);
        void Create(Ward Ward);
        void Update(Ward Ward);
        void Delete(int id);
    }
}