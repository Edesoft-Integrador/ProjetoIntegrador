using seq.Application.Interfaces;
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Processo;
using System.Threading.Tasks;

namespace seq.Application.Services
{
    public class AmazonAppService : AppServiceBase<GeralHeaderModel>, IAmazonAppService
    {
        private readonly IGeralHeaderService _serviceBase;
        private readonly IAmazonProcessaXML _amazonProcessaXML;

        public AmazonAppService(IGeralHeaderService serviceBase, IAmazonProcessaXML amazonProcessaXML) : base(serviceBase)
        {
            _serviceBase = serviceBase;
            _amazonProcessaXML = amazonProcessaXML;
        }

        public async Task<int> ProcessaXML(string value)
        {
           return await _amazonProcessaXML.ProcessaXML(value);
        }
    }
}
