using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ISplashScreenItemService
    {
        IEnumerable<SplashScreenItem> GetAll();
        SplashScreenItem Get(int id);
        void Create(SplashScreenItem SplashScreenItem);
        void Update(SplashScreenItem SplashScreenItem);
        void Delete(int id);
    }
}