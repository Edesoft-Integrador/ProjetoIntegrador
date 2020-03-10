
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class AmazonDetalheService : ServiceBase<AmazonDetalheModel>, IAmazonDetalheService
    {
        private readonly IAmazonDetalheRepository _repository;
        public AmazonDetalheService(IAmazonDetalheRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
