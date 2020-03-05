
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;

namespace seq.Applications.Services
{
    public class ArquivoAppService : AppServiceBase<ArquivoModel>, IArquivoAppService
    {

        private readonly IArquivoService _serviceBase;

        public ArquivoAppService(IArquivoService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
    }
}
