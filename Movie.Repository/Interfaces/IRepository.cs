using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Movie.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //FIND
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllWhere(Expression<Func<TEntity,bool>> predicate);

        //ADD
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //REMOVE
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
