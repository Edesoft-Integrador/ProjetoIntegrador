using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class AmazonLUFTService : ServiceBase<AmazonLUFTModel>, IAmazonLUFTService
    {
        private readonly IAmazonLUFTRepository _repository;
        public AmazonLUFTService(IAmazonLUFTRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
