using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;

namespace seq.Domain.Services
{
    public class ArquivoService : ServiceBase<ArquivoModel>, IArquivoService
    {
        private readonly IArquivorepository _repository;
        public ArquivoService(IArquivorepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
