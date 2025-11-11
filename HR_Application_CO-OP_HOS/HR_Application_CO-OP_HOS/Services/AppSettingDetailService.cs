using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AppSettingDetailService : IAppSettingDetailService
    {
        private readonly IRepository<AppSettingsDetail> _repo;
        public AppSettingDetailService(IRepository<AppSettingsDetail> repo) { _repo = repo; }
        public IEnumerable<AppSettingsDetail> GetAll() => _repo.GetAll();
        public AppSettingsDetail Get(int id) => _repo.Get(id);
        public void Create(AppSettingsDetail appSettingsDetail) { _repo.Add(appSettingsDetail); _repo.Save(); }
        public void Update(AppSettingsDetail appSettingsDetail) { _repo.Update(appSettingsDetail); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}