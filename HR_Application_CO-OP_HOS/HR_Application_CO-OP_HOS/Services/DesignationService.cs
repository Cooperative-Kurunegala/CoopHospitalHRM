using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DesignationService : IDesignationService
    {
        private readonly IRepository<Designation> _repo;
        public DesignationService(IRepository<Designation> repo) { _repo = repo; }
        public IEnumerable<Designation> GetAll() => _repo.GetAll();
        public Designation Get(int id) => _repo.Get(id);
        public void Create(Designation designation) { _repo.Add(designation); _repo.Save(); }
        public void Update(Designation designation) { _repo.Update(designation); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}