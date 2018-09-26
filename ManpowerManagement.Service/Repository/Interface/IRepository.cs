using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ManpowerManagement.Service.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        int Count();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);

        void BeginTransaction();
        void CommitTransaction();
        void RoleBack();
        IEnumerable<TEntity> GetAll();
    }
}
