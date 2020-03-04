using seq.Domain.Entities.Depara;
using seq.Domain.Entities.Integrado;
using seq.Domain.Interface.Application.Integrado;
using seq.Domain.Interface.Repository.Integrado;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace seq.Application.Integrado
{
    public class IntegradoAppService : IIntegradoAppService, IDisposable
    {
        private readonly IIntegradoRepository _context;

        public IntegradoAppService(IIntegradoRepository context)
        {
            _context = context;
        }

        public async Task<bool> Delete(IntegradoModel obj)
        {
            var retorno = await _context.Delete(obj);
            return retorno;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
       }

        public async Task<IntegradoModel> Find(IntegradoModel obj)
        {
            throw new NotImplementedException();
        }

        public async Task<long> Insert(IntegradoModel obj)
        {
            var retorno = await _context.Insert(obj);
            return retorno;
        }

        public async Task<List<IntegradoModel>> Search(IntegradoModel obj)
        {
            var retorno = await _context.Search(obj);
            return retorno;
        }

        public async Task<bool> Update(IntegradoModel obj)
        {
            var retorno = await _context.Update(obj);
            return retorno;
        }
    }
}
