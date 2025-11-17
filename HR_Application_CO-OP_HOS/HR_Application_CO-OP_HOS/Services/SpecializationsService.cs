using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SpecializationsService : ISpecializationsService
    {
        private readonly IRepository<Specialization> _repo;
        public SpecializationsService(IRepository<Specialization> repo) { _repo = repo; }
        public IEnumerable<Specialization> GetAll() => _repo.GetAll();
        public Specialization Get(int id) => _repo.Get(id);
        public void Create(Specialization Specialization) { _repo.Add(Specialization); _repo.Save(); }
        public void Update(Specialization Specialization) { _repo.Update(Specialization); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}