using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repository
{
    public class AmazonLUFTRepository : RepositoryBase<AmazonLUFTModel>, IAmazonLUFTRepository
    {
        public AmazonLUFTRepository(WebDBContext context) : base(context)
        {
        }

    }
}
