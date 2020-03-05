
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Applications.Services
{
    public class AmazonLUFTAppService : AppServiceBase<AmazonLUFTModel>, IAmazonLUFTAppService
    {

        private readonly IAmazonLUFTService _serviceBase;

        public AmazonLUFTAppService(IAmazonLUFTService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
