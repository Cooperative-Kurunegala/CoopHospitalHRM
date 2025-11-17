using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SystemConfigurationsService : ISystemConfigurationsService
    {
        private readonly IRepository<SystemConfiguration> _repo;
        public SystemConfigurationsService(IRepository<SystemConfiguration> repo) { _repo = repo; }
        public IEnumerable<SystemConfiguration> GetAll() => _repo.GetAll();
        public SystemConfiguration Get(int id) => _repo.Get(id);
        public void Create(SystemConfiguration SystemConfiguration) { _repo.Add(SystemConfiguration); _repo.Save(); }
        public void Update(SystemConfiguration SystemConfiguration) { _repo.Update(SystemConfiguration); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}