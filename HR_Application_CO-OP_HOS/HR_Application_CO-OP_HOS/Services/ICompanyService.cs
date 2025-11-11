using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        void Create(Company company);
        void Update(Company company);
        void Delete(int id);
    }
}