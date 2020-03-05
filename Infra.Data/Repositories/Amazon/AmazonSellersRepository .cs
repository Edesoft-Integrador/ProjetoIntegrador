using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;

namespace seq.Infra.Data.Repository
{
    public class AmazonSellersRepository : RepositoryBase<AmazonSellersModel>, IAmazonSellersRepository
    {
        public AmazonSellersRepository(WebDBContext context) : base(context)
        {
        }

    }
}
