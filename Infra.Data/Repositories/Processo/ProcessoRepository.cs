using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repository
{
    public class ProcessoRepository : RepositoryBase<ProcessoModel>, IProcessoRepository
    {
        public ProcessoRepository(WebDBContext context) : base(context)
        {
        }

    }
}
