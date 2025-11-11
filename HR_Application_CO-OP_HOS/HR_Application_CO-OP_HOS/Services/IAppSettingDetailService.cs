using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAppSettingDetailService
    {
        IEnumerable<AppSettingsDetail> GetAll();
        AppSettingsDetail Get(int id);
        void Create(AppSettingsDetail appSettingsDetail);
        void Update(AppSettingsDetail appSettingsDetail);
        void Delete(int id);
    }
}