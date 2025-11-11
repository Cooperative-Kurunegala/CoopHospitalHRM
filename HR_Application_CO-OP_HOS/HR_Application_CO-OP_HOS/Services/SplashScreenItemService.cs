using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SplashScreenItemService : ISplashScreenItemService
    {
        private readonly IRepository<SplashScreenItem> _repo;
        public SplashScreenItemService(IRepository<SplashScreenItem> repo) { _repo = repo; }
        public IEnumerable<SplashScreenItem> GetAll() => _repo.GetAll();
        public SplashScreenItem Get(int id) => _repo.Get(id);
        public void Create(SplashScreenItem SplashScreenItem) { _repo.Add(SplashScreenItem); _repo.Save(); }
        public void Update(SplashScreenItem SplashScreenItem) { _repo.Update(SplashScreenItem); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}