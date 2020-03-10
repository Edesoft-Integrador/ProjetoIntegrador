using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repository
{
    public class GeralHeaderRepository : RepositoryBase<GeralHeaderModel>, IGeralHeaderRepository
    {
        public GeralHeaderRepository(WebDBContext context) : base(context)
        {
        }

    }
}
