using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eim.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        Task<Int64> Insert(TEntity obj);
        Task<TEntity> Find(TEntity obj);
        Task<List<TEntity>> Search(TEntity obj);
        Task<bool> Update(TEntity obj);
        Task<bool> Delete(TEntity obj);
    }
}
