using seq.Domain.Entities;
using System.Threading.Tasks;

namespace seq.Application.Interfaces
{
    public interface IAmazonHeaderAppService : IAppServiceBase<AmazonHeaderModel>
    {
        Task<int> ProcessaXML(string value);
    }
}
