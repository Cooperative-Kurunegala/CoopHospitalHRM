using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services 
{ 
public class AppSettingService : IAppSettingService
{
    private readonly IRepository<AppSetting> _repo;
    public AppSettingService(IRepository<AppSetting> repo) { _repo = repo; }
    public IEnumerable<AppSetting> GetAll() => _repo.GetAll();
    public AppSetting Get(int id) => _repo.Get(id);
    public void Create(AppSetting appSetting) { _repo.Add(appSetting); _repo.Save(); }
    public void Update(AppSetting appSetting) { _repo.Update(appSetting); _repo.Save(); }
    public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
}
}