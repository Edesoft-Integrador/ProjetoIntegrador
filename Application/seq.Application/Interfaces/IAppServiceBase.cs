
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace seq.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        Task<long> AddAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(TEntity obj);
        Task<bool> AnyAsync(TEntity obj);
        void Dispose();
        Task<TEntity> GetByIDAsync(long ID);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddRangeAsync(IEnumerable<TEntity> obj);
        Task UpdateRangeAsync(IEnumerable<TEntity> obj);
    }
}
