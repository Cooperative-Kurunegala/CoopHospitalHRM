using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BanksService : IBanksService
    {
        private readonly IRepository<Bank> _repo;
        public BanksService(IRepository<Bank> repo) { _repo = repo; }
        public IEnumerable<Bank> GetAll() => _repo.GetAll();
        public Bank Get(int id) => _repo.Get(id);
        public void Create(Bank Bank) { _repo.Add(Bank); _repo.Save(); }
        public void Update(Bank Bank) { _repo.Update(Bank); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}