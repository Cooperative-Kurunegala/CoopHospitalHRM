using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class MenuConfigurationService : IMenuConfigurationService
    {
        private readonly IRepository<MenuConfiguration> _repo;
        public MenuConfigurationService(IRepository<MenuConfiguration> repo) { _repo = repo; }
        public IEnumerable<MenuConfiguration> GetAll() => _repo.GetAll();
        public MenuConfiguration Get(int id) => _repo.Get(id);
        public void Create(MenuConfiguration MenuConfiguration) { _repo.Add(MenuConfiguration); _repo.Save(); }
        public void Update(MenuConfiguration MenuConfiguration) { _repo.Update(MenuConfiguration); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}