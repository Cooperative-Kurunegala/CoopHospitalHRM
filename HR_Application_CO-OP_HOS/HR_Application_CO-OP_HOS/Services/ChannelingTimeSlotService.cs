using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChannelingTimeSlotService : IChannelingTimeSlotService
    {
        private readonly IRepository<ChannelingTimeSlot> _repo;
        public ChannelingTimeSlotService(IRepository<ChannelingTimeSlot> repo) { _repo = repo; }
        public IEnumerable<ChannelingTimeSlot> GetAll() => _repo.GetAll();
        public ChannelingTimeSlot Get(int id) => _repo.Get(id);
        public void Create(ChannelingTimeSlot channelingTimeSlot) { _repo.Add(channelingTimeSlot); _repo.Save(); }
        public void Update(ChannelingTimeSlot channelingTimeSlot) { _repo.Update(channelingTimeSlot); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}