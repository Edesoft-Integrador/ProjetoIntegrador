using Microsoft.EntityFrameworkCore;
using seq.Domain.Interfaces.Repositories;
using seq.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using System.Transactions;

namespace seq.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        #region RepositoryBase
        protected readonly WebDBContext _context;

        public RepositoryBase(WebDBContext context )
        {
            _context = context;
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> obj)
        {
                try
                {
                _context.ChangeTracker.LazyLoadingEnabled = false;
                _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                _context.ChangeTracker.AutoDetectChangesEnabled = false;

                await _context.BulkInsertAsync(obj.ToList());
                //await _context.Set<TEntity>().AddRangeAsync(obj);
                //await _context.SaveChangesAsync();
            }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Set<TEntity>().Any())
                    {
                        return;
                    }
                    else
                    {
                        throw;
                    }
                }
            
        }

        public virtual async Task<long> AddAsync(TEntity obj)
        {
            try
            {

                _context.ChangeTracker.LazyLoadingEnabled = false;
                _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                _context.ChangeTracker.AutoDetectChangesEnabled = false;


                await _context.Set<TEntity>().AddAsync(obj);
                return (long)await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Set<TEntity>().Any())
                {
                    return 0;
                }
                else
                {
                    throw;
                }
            }
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            try
            {
                      _context.Entry(obj).State = EntityState.Modified;
                      _context.Update(obj);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Set<TEntity>().Any())
                {
                    return;
                }
                else
                {
                    throw;
                }
            }
        }

        public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> obj)
        {
            try
            {
                //      _context.Entry(obj).State = EntityState.Modified;
                //await _context.SaveChangesAsync();
                await _context.BulkUpdateAsync(obj.ToList());
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Set<TEntity>().Any())
                {
                    return;
                }
                else
                {
                    throw;
                }
            }
        }

        public virtual async Task RemoveAsync(TEntity obj)
        {
                  _context.Set<TEntity>().Remove(obj);
           await  _context.SaveChangesAsync();
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIDAsync(long ID)
        {
            return await _context.Set<TEntity>().FindAsync(ID);
        }

        public virtual async Task<bool> AnyAsync(TEntity obj)
        {
            return await _context.Set<TEntity>().AsNoTracking().AnyAsync(x => x == obj);
        }

        #endregion
    }
}
