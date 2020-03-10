using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repositories
{
    public class LayoutRepository : RepositoryBase<LayoutModel>, ILayoutRepository
    {
        public LayoutRepository(WebDBContext context) : base(context)
        {
        }

    }
}
