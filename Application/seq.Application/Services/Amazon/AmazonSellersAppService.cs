
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Applications.Services
{
    public class AmazonSellersAppService : AppServiceBase<AmazonSellersModel>, IAmazonSellersAppService
    {

        private readonly IAmazonSellersService _serviceBase;

        public AmazonSellersAppService(IAmazonSellersService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
