using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class CheckManagmentService : ICheckManagmentService
    {
        private readonly IRepository<CheckManagment> _repo;
        public CheckManagmentService(IRepository<CheckManagment> repo) { _repo = repo; }
        public IEnumerable<CheckManagment> GetAll() => _repo.GetAll();
        public CheckManagment Get(int id) => _repo.Get(id);
        public void Create(CheckManagment checkManagment) { _repo.Add(checkManagment); _repo.Save(); }
        public void Update(CheckManagment checkManagment) { _repo.Update(checkManagment); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}