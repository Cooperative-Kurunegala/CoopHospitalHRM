using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SystemLogsService : ISystemLogsService
    {
        private readonly IRepository<SystemLog> _repo;
        public SystemLogsService(IRepository<SystemLog> repo) { _repo = repo; }
        public IEnumerable<SystemLog> GetAll() => _repo.GetAll();
        public SystemLog Get(int id) => _repo.Get(id);
        public void Create(SystemLog SystemLog) { _repo.Add(SystemLog); _repo.Save(); }
        public void Update(SystemLog SystemLog) { _repo.Update(SystemLog); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}