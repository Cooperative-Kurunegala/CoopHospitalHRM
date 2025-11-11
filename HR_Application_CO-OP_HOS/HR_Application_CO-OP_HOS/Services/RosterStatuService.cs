using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RosterStatuService : IRosterStatuService
    {
        private readonly IRepository<RosterStatu> _repo;
        public RosterStatuService(IRepository<RosterStatu> repo) { _repo = repo; }
        public IEnumerable<RosterStatu> GetAll() => _repo.GetAll();
        public RosterStatu Get(int id) => _repo.Get(id);
        public void Create(RosterStatu RosterStatu) { _repo.Add(RosterStatu); _repo.Save(); }
        public void Update(RosterStatu RosterStatu) { _repo.Update(RosterStatu); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}