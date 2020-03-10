using seq.Domain.Entities;
using System.Threading.Tasks;

namespace seq.Application.Interfaces
{
    public interface IAmazonAppService : IAppServiceBase<GeralHeaderModel>
    {
        Task<int> ProcessaXML(string value);
    }
}