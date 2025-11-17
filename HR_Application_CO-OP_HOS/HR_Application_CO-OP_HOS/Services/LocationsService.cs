using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LocationsService : ILocationService
    {
        private readonly IRepository<Location> _repo;
        public LocationsService(IRepository<Location> repo) { _repo = repo; }
        public IEnumerable<Location> GetAll() => _repo.GetAll();
        public Location Get(int id) => _repo.Get(id);
        public void Create(Location Location) { _repo.Add(Location); _repo.Save(); }
        public void Update(Location Location) { _repo.Update(Location); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}