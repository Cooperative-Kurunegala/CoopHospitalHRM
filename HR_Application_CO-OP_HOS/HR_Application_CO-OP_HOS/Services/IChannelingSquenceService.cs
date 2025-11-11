using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChannelingSquenceService
    {
        IEnumerable<ChannelingSquence> GetAll();
        ChannelingSquence Get(int id);
        void Create(ChannelingSquence channelingSquence);
        void Update(ChannelingSquence channelingSquence);
        void Delete(int id);
    }
}