//using seq.Domain.Entities.Depara;
//using seq.Domain.Entities.Tipo;
//using seq.Domain.Interface.Application.Tipo;
//using seq.Domain.Interface.Repository.Tipo;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace seq.Application.Tipo
//{
//    public class TipoAppService : ITipoAppService, IDisposable
//    {
//        private readonly ITipoRepository _context;

//        public TipoAppService(ITipoRepository context)
//        {
//            _context = context;
//        }

//        public async Task<bool> Delete(TipoModel obj)
//        {
//            var retorno = await _context.Delete(obj);
//            return retorno;
//        }

//        public void Dispose()
//        {
//            //throw new NotImplementedException();
//       }

//        public async Task<TipoModel> Find(TipoModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(TipoModel obj)
//        {
//            var retorno = await _context.Insert(obj);
//            return retorno;
//        }

//        public async Task<List<TipoModel>> Search(TipoModel obj)
//        {
//            var retorno = await _context.Search(obj);
//            return retorno;
//        }

//        public async Task<bool> Update(TipoModel obj)
//        {
//            var retorno = await _context.Update(obj);
//            return retorno;
//        }
//    }
//}
