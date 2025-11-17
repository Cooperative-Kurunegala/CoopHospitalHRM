using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ICompaniesService
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        void Create(Company Company);
        void Update(Company Company);
        void Delete(int id);
    }
}