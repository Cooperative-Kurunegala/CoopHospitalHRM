using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class CalendarForPayoutService : ICalendarForPayoutService
    {
        private readonly IRepository<CalanderForPayout> _repo;
        public CalendarForPayoutService(IRepository<CalanderForPayout> repo) { _repo = repo; }
        public IEnumerable<CalanderForPayout> GetAll() => _repo.GetAll();
        public CalanderForPayout Get(int id) => _repo.Get(id);
        public void Create(CalanderForPayout calendarForPayout) { _repo.Add(calendarForPayout); _repo.Save(); }
        public void Update(CalanderForPayout calendarForPayout) { _repo.Update(calendarForPayout); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}