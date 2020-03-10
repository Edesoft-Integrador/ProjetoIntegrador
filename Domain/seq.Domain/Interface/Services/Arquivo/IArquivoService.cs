using seq.Domain.Entities;
using System.Collections;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Services
{
    public interface IArquivoService: IServiceBase<ArquivoModel>
    {
        Task<IEnumerable> Search(long? id, string descricao);
    }
}
