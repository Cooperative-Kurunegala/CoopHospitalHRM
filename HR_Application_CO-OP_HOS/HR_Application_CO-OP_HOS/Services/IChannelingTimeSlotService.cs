using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChannelingTimeSlotService
    {
        IEnumerable<ChannelingTimeSlot> GetAll();
        ChannelingTimeSlot Get(int id);
        void Create(ChannelingTimeSlot channelingTimeSlot);
        void Update(ChannelingTimeSlot channelingTimeSlot);
        void Delete(int id);
    }
}