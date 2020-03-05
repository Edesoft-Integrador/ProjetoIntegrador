using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class AmazonSellersService : ServiceBase<AmazonSellersModel>, IAmazonSellersService
    {
        private readonly IAmazonSellersRepository _repository;
        public AmazonSellersService(IAmazonSellersRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
