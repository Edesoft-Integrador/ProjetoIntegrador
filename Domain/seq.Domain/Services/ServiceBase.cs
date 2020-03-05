using seq.Domain.Interface.Services;
using seq.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace seq.Domain.Services
{

    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<long> AddAsync(TEntity obj)
        {
            return await _repository.AddAsync(obj).ConfigureAwait(true);
        }

        public void Dispose()
        {
           _repository.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync().ConfigureAwait(true);
        }

        public async Task<TEntity> GetByIDAsync(int ID)
        {
            return await _repository.GetByIDAsync(ID).ConfigureAwait(true);
        }

        public async Task RemoveAsync(TEntity obj)
        {
            await _repository.RemoveAsync(obj).ConfigureAwait(true);
        }

        public async Task UpdateAsync(TEntity obj)
        {
           await _repository.UpdateAsync(obj).ConfigureAwait(true);
        }

        public async Task<bool> AnyAsync(TEntity obj)
        {
           return await _repository.AnyAsync(obj).ConfigureAwait(true);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> obj)
        {
            await _repository.AddRangeAsync(obj).ConfigureAwait(true);
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> obj)
        {
            await _repository.UpdateRangeAsync(obj).ConfigureAwait(true);

        }
    }
}
