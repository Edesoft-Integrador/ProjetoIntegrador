using seq.Domain.Entities;
using System.Collections;
using System.Threading.Tasks;

namespace seq.Application.Interfaces
{
    public interface IArquivoAppService : IAppServiceBase<ArquivoModel>
    {
        Task<IEnumerable> Search(long? id, string descricao);

        Task<IEnumerable> SearchTeste(long? id, string descricao);
    }
}
