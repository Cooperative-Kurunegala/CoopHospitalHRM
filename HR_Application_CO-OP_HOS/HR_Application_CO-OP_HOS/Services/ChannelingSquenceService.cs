using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChannelingSquenceService : IChannelingSquenceService
    {
        private readonly IRepository<ChannelingSquence> _repo;
        public ChannelingSquenceService(IRepository<ChannelingSquence> repo) { _repo = repo; }
        public IEnumerable<ChannelingSquence> GetAll() => _repo.GetAll();
        public ChannelingSquence Get(int id) => _repo.Get(id);
        public void Create(ChannelingSquence channelingSquence) { _repo.Add(channelingSquence); _repo.Save(); }
        public void Update(ChannelingSquence channelingSquence) { _repo.Update(channelingSquence); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}