
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Applications.Services
{
    public class AmazonDetalheAppService : AppServiceBase<AmazonDetalheModel>, IAmazonDetalheAppService
    {

        private readonly IAmazonDetalheService _serviceBase;

        public AmazonDetalheAppService(IAmazonDetalheService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
