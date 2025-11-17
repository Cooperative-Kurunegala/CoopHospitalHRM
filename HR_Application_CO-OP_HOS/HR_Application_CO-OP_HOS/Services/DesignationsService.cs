using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DesignationsService : IDesignationsService
    {
        private readonly IRepository<Designation> _repo;
        public DesignationsService(IRepository<Designation> repo) { _repo = repo; }
        public IEnumerable<Designation> GetAll() => _repo.GetAll();
        public Designation Get(int id) => _repo.Get(id);
        public void Create(Designation Designation) { _repo.Add(Designation); _repo.Save(); }
        public void Update(Designation Designation) { _repo.Update(Designation); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}