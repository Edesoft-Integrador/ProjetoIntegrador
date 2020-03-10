
using seq.Domain.Entities;
using seq.Domain.Entities.Geral;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class AmazonHeaderService : ServiceBase<GeralHeaderModel>, IAmazonService
    {
        private readonly IGeralHeaderRepository _repository;
        public AmazonHeaderService(IGeralHeaderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
