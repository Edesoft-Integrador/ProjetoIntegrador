using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<long> AddAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(TEntity obj);
        Task<bool> AnyAsync(TEntity obj);
        void Dispose();
        Task<TEntity> GetByIDAsync(int ID);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddRangeAsync(IEnumerable<TEntity> obj);
        Task UpdateRangeAsync(IEnumerable<TEntity> obj);
    }
}
