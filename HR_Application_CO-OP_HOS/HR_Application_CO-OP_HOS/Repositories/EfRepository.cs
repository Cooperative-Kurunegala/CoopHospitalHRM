using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        protected readonly HospitalHRDataEntities _context;
        public EfRepository(HospitalHRDataEntities context) { _context = context; }
        public IEnumerable<T> GetAll() => _context.Set<T>().AsNoTracking().ToList();
        public T Get(int id) => _context.Set<T>().Find(id);
        public void Add(T entity) { _context.Set<T>().Add(entity); }
        public void Update(T entity) { _context.Entry(entity).State = EntityState.Modified; }
        public void Delete(int id)
        {
            var e = Get(id);
            if (e != null) _context.Set<T>().Remove(e);
        }
        public void Save() { _context.SaveChanges(); }
    }
}