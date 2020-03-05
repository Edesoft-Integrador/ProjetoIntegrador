
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Applications.Services
{
    public class ProcessoAppService : AppServiceBase<ProcessoModel>, IProcessoAppService
    {

        private readonly IProcessoService _serviceBase;

        public ProcessoAppService(IProcessoService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
