//using seq.Domain.Entities.Depara;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace seq.Application.Depara
//{
//    public class DeparaAppService : IDeparaService, IDisposable
//    {
//        private readonly IDeparaRepository _context;

//        public DeparaAppService(IDeparaRepository context)
//        {
//            _context = context;
//        }
//        public async Task<bool> Delete(DeparaModel obj)
//        {
//            var retorno = await _context.Delete(obj);
//            return retorno;
//        }

//        public void Dispose()
//        {
//            //throw new NotImplementedException();
//        }

//        public async Task<DeparaModel> Find(DeparaModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(DeparaModel obj)
//        {
//            var retorno = await _context.Insert(obj);
//            return retorno;
//        }

//        public async Task<List<DeparaModel>> Search(DeparaModel obj)
//        {
//            var retorno = await _context.Search(obj);
//            return retorno;
//        }

//        public async Task<bool> Update(DeparaModel obj)
//        {
//            var retorno = await _context.Update(obj);
//            return retorno;
//        }
//    }
//}
