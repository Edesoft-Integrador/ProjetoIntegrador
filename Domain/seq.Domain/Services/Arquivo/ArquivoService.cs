using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;

namespace seq.Domain.Services
{
    public class ProcessoService : ServiceBase<ProcessoModel>, IProcessoService
    {
        private readonly IProcessoRepository _repository;

        public ProcessoService(IProcessoRepository repository) : base(repository)
        {
            _repository = repository;
        }


    }
}
