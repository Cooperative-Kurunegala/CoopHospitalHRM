using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class OnCallSchedulesService : IOnCallSchedulesService
    {
        private readonly IRepository<OnCallSchedule> _repo;
        public OnCallSchedulesService(IRepository<OnCallSchedule> repo) { _repo = repo; }
        public IEnumerable<OnCallSchedule> GetAll() => _repo.GetAll();
        public OnCallSchedule Get(int id) => _repo.Get(id);
        public void Create(OnCallSchedule OnCallSchedule) { _repo.Add(OnCallSchedule); _repo.Save(); }
        public void Update(OnCallSchedule OnCallSchedule) { _repo.Update(OnCallSchedule); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}