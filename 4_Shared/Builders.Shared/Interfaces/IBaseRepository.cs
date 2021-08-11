using System;
using System.Collections.Generic;

namespace Builders.Shared.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : IDocument
    {
        void Create(TEntity entity);
        bool Delete(TEntity entity);
        void Delete(Guid id);
        void Edit(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        void SaveChanges();
    }
}