using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class NopayService : INopayService
    {
        private readonly IRepository<Nopay> _repo;
        public NopayService(IRepository<Nopay> repo) { _repo = repo; }
        public IEnumerable<Nopay> GetAll() => _repo.GetAll();
        public Nopay Get(int id) => _repo.Get(id);
        public void Create(Nopay Nopay) { _repo.Add(Nopay); _repo.Save(); }
        public void Update(Nopay Nopay) { _repo.Update(Nopay); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}
