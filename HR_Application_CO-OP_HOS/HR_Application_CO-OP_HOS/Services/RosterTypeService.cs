using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RosterTypeService : IRosterTypeService
    {
        private readonly IRepository<RosterType> _repo;
        public RosterTypeService(IRepository<RosterType> repo) { _repo = repo; }
        public IEnumerable<RosterType> GetAll() => _repo.GetAll();
        public RosterType Get(int id) => _repo.Get(id);
        public void Create(RosterType RosterType) { _repo.Add(RosterType); _repo.Save(); }
        public void Update(RosterType RosterType) { _repo.Update(RosterType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}