
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class GeralHeaderService : ServiceBase<GeralHeaderModel>, IGeralHeaderService
    {
        private readonly IGeralHeaderRepository _repository;
        public GeralHeaderService(IGeralHeaderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
