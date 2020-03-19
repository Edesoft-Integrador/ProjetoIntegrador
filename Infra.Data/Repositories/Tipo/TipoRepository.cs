using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repositories
{
    public class TipoRepository : RepositoryBase<TipoModel>, ITipoRepository
    {
        public TipoRepository(WebDBContext context) : base(context)
        {
        }

    }
}
