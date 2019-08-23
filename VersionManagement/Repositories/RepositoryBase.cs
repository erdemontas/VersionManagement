using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class RepositoryBase<T> : IRepository<T> 
        where T : SharedEntities
    {
        private readonly VManagementContext vmContext;
        private DbSet<T> Table { get; set; }
        public RepositoryBase(VManagementContext vmContext)
        {
            this.vmContext = vmContext;
            Table = vmContext.Set<T>();
        }
        //complete
        public IQueryable<T> Get(bool includeDeleted = false) => Table.Where(x => !x.IsDeleted || includeDeleted);
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate);
        }
        //complete
        public T GetById(Guid id)
        {
            return Table.Find(id);
        }

        //complete
        public bool Delete(T obj)
        {
            Table.Remove(obj);
            return Save();
        }

        //complete
        public bool Insert(T obj)
        {
            Table.Add(obj);
            return Save();
        }

        //complete
        public bool Save()
        {
            try
            {
                vmContext.SaveChanges();
                return true;
            }
            catch
            {
                // TODO: Log Exceptions
                return false;
            }
        }

        //complete
        public bool Update(T obj)
        {
            Table.Update(obj);
            return Save();
        }
    }
}
