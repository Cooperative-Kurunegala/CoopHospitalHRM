using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LeavesService : ILeavesService
    {
        private readonly IRepository<Leaf> _repo;
        public LeavesService(IRepository<Leaf> repo) { _repo = repo; }
        public IEnumerable<Leaf> GetAll() => _repo.GetAll();
        public Leaf Get(int id) => _repo.Get(id);
        public void Create(Leaf Leave) { _repo.Add(Leave); _repo.Save(); }
        public void Update(Leaf Leave) { _repo.Update(Leave); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}