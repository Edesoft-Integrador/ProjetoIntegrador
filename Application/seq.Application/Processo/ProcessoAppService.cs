using seq.Domain.Entities.Processo;
using seq.Domain.Interface.Application.Processo;
using seq.Domain.Interface.Repository.Processo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace seq.Application.Processo
{
    public class ProcessoAppService : IProcessoAppService, IDisposable
    {
        private readonly IProcessoRepository _context;

        public ProcessoAppService(IProcessoRepository context)
        {
            _context = context;
        }
        public async Task<bool> Delete(ProcessoModel obj)
        {
            var retorno = await _context.Delete(obj);
            return retorno;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<ProcessoModel> Find(ProcessoModel obj)
        {
            throw new NotImplementedException();
        }

        public async Task<long> Insert(ProcessoModel obj)
        {
            var retorno = await _context.Insert(obj);
            return retorno;
        }

        public async Task<List<ProcessoModel>> Search(ProcessoModel obj)
        {
            var retorno = await _context.Search(obj);
            return retorno;
        }

        public async Task<bool> Update(ProcessoModel obj)
        {
            var retorno = await _context.Update(obj);
            return retorno;
        }
    }
}

