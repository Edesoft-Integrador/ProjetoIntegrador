
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Application.Services
{
    public class LayoutAppService : AppServiceBase<LayoutModel>, ILayoutAppService
    {

        private readonly ILayoutService _serviceBase;

        public LayoutAppService(ILayoutService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
