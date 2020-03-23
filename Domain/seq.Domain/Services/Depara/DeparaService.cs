using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;

namespace seq.Domain.Services
{
    public class DeparaService : ServiceBase<DeparaModel>, IDeparaService
    {
        private readonly IDeparaRepository _repository;
        public DeparaService(IDeparaRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
