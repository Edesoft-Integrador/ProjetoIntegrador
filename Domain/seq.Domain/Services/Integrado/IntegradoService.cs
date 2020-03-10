using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;

namespace seq.Domain.Services
{
    public class IntegradoService : ServiceBase<IntegradoModel>, IIntegradoService
    {
        private readonly IIntegradoRepository _repository;
        public IntegradoService(IIntegradoRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
