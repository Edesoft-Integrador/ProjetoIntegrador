
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Application.Services
{
    public class TipoAppService : AppServiceBase<TipoModel>, ITipoAppService
    {

        private readonly ITipoService _serviceBase;

        public TipoAppService(ITipoService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
