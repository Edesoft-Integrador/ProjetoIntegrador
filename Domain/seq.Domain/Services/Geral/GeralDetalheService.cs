
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class GeralDetalheService : ServiceBase<GeralDetalheModel>, IGeralDetalheService
    {
        private readonly IGeralDetalheRepository _repository;
        public GeralDetalheService(IGeralDetalheRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
