using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;

namespace seq.Domain.Services
{
    public class TipoService : ServiceBase<TipoModel>, ITipoService
    {
        private readonly ITipoRepository _repository;
        public TipoService(ITipoRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
