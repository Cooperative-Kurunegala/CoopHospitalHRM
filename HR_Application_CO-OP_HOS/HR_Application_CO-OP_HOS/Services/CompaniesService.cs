using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class CompaniesService : ICompaniesService
    {
        private readonly IRepository<Company> _repo;
        public CompaniesService(IRepository<Company> repo) { _repo = repo; }
        public IEnumerable<Company> GetAll() => _repo.GetAll();
        public Company Get(int id) => _repo.Get(id);
        public void Create(Company Company) { _repo.Add(Company); _repo.Save(); }
        public void Update(Company Company) { _repo.Update(Company); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}