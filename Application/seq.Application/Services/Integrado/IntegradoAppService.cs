
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Application.Services
{
    public class IntegradoAppService : AppServiceBase<IntegradoModel>, IIntegradoAppService
    {

        private readonly IIntegradoService _serviceBase;

        public IntegradoAppService(IIntegradoService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
