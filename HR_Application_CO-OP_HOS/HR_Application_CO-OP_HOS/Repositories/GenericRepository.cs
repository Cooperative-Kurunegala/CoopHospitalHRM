using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HR_Application_CO_OP_HOS.Models;

namespace HR_Application_CO_OP_HOS.Repositories
{
    public class GenericRepository<T> where T : class
    {
        internal HRMSContext context;
        internal DbSet<T> dbSet;

        public GenericRepository(HRMSContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public T GetById (object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            T entityToDelete = dbSet.Find(id);
            if(entityToDelete != null)
            {
                dbSet.Remove(entityToDelete);
            }
                
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

    }
}