
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Applications.Services
{
    public class AmazonHeaderAppService : AppServiceBase<AmazonHeaderModel>, IAmazonHeaderAppService
    {

        private readonly IAmazonHeaderService _serviceBase;

        public AmazonHeaderAppService(IAmazonHeaderService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
