using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LogDetailService : ILogDetailService
    {
        private readonly IRepository<LogDetail> _repo;
        public LogDetailService(IRepository<LogDetail> repo) { _repo = repo; }
        public IEnumerable<LogDetail> GetAll() => _repo.GetAll();
        public LogDetail Get(int id) => _repo.Get(id);
        public void Create(LogDetail LogDetail) { _repo.Add(LogDetail); _repo.Save(); }
        public void Update(LogDetail LogDetail) { _repo.Update(LogDetail); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}
