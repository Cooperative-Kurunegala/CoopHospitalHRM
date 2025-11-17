using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class WardsService : IWardsService
    {
        private readonly IRepository<Ward> _repo;
        public WardsService(IRepository<Ward> repo) { _repo = repo; }
        public IEnumerable<Ward> GetAll() => _repo.GetAll();
        public Ward Get(int id) => _repo.Get(id);
        public void Create(Ward Ward) { _repo.Add(Ward); _repo.Save(); }
        public void Update(Ward Ward) { _repo.Update(Ward); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}