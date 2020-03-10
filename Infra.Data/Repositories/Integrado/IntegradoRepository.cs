using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repositories
{
    public class IntegradoRepository : RepositoryBase<IntegradoModel>, IIntegradoRepository
    {
        public IntegradoRepository(WebDBContext context) : base(context)
        {
        }

    }
}
