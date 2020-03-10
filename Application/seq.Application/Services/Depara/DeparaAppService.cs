
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Application.Services
{
    public class DeparaAppService : AppServiceBase<DeparaModel>, IDeparaAppService
    {

        private readonly IDeparaService _serviceBase;

        public DeparaAppService(IDeparaService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
