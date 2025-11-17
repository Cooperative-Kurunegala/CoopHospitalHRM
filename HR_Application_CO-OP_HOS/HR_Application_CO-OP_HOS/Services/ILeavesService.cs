using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILeavesService
    {
        IEnumerable<Leaf> GetAll();
        Leaf Get(int id);
        void Create(Leaf Leave);
        void Update(Leaf Leave);
        void Delete(int id);
    }
}