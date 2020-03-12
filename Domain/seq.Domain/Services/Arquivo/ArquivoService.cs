using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Collections;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class ArquivoService : ServiceBase<ArquivoModel>, IArquivoService
    {
        private readonly IArquivorepository _repository;

        public ArquivoService(IArquivorepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable> Search(long? id, string descricao)
        {
            return _repository.Search(id, descricao);
        }

        public async Task<IEnumerable> SearchTeste(long? id, string descricao)
        {
            return await _repository.SearchTeste(id, descricao);
        }
    }
}
