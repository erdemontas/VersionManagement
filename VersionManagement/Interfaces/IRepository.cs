using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.Interfaces
{
    public interface IRepository<T>
        where T : SharedEntities
    {
        IQueryable<T> Get(bool includeDeleted = false);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate);
        T GetById(Guid id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        bool Save();
    }
}
