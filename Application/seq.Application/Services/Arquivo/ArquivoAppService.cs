﻿
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;
using System.Threading.Tasks;
using System.Collections;

namespace seq.Application.Services
{
    public class ArquivoAppService : AppServiceBase<ArquivoModel>, IArquivoAppService
    {

        private readonly IArquivoService _serviceBase;

        public ArquivoAppService(IArquivoService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public async Task<IEnumerable> Search(long? id, string descricao)
        {
            return await _serviceBase.Search(id, descricao);
        }

        public async Task<IEnumerable> SearchTeste(long? id, string descricao)
        {
            return await _serviceBase.SearchTeste(id, descricao);
        }

        public async Task<IEnumerable> SearchTesteADO(long? id, string descricao)
        {
            return await _serviceBase.SearchTesteADO(id, descricao);
        }
    }
}
