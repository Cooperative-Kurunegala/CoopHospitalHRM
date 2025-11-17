using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PerformanceAppraisalsService : IPerformanceAppraisalsService
    {
        private readonly IRepository<PerformanceAppraisal> _repo;
        public PerformanceAppraisalsService(IRepository<PerformanceAppraisal> repo) { _repo = repo; }
        public IEnumerable<PerformanceAppraisal> GetAll() => _repo.GetAll();
        public PerformanceAppraisal Get(int id) => _repo.Get(id);
        public void Create(PerformanceAppraisal PerformanceAppraisal) { _repo.Add(PerformanceAppraisal); _repo.Save(); }
        public void Update(PerformanceAppraisal PerformanceAppraisal) { _repo.Update(PerformanceAppraisal); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}