using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Builders.Shared.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : IDocument
    {
        Task CreateAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAll();

    }
}