
using seq.Domain.Entities;
using seq.Domain.Interfaces.Repositories;
using System.Collections;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Repositories
{
    public interface IArquivorepository : IRepositoryBase<ArquivoModel>
    {
        Task<IEnumerable> Search(long? id, string descricao);
    }
}
