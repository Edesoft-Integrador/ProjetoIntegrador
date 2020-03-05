//using seq.Domain.Entities.Layout;
//using seq.Domain.Interface.Application.Layout;
//using seq.Domain.Interface.Repository.Layout;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace seq.Application.Layout
//{
//    public class LayoutAppService : ILayoutAppService, IDisposable
//    {
//        private readonly ILayoutRepository _context;

//        public LayoutAppService(ILayoutRepository context)
//        {
//            _context = context;
//        }
//        public async Task<bool> Delete(LayoutModel obj)
//        {
//            var retorno = await _context.Delete(obj);
//            return retorno;
//        }

//        public void Dispose()
//        {
//            //throw new NotImplementedException();
//        }

//        public async Task<LayoutModel> Find(LayoutModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(LayoutModel obj)
//        {
//            var retorno = await _context.Insert(obj);
//            return retorno;
//        }

//        public async Task<List<LayoutModel>> Search(LayoutModel obj)
//        {
//            var retorno = await _context.Search(obj);
//            return retorno;
//        }

//        public async Task<bool> Update(LayoutModel obj)
//        {
//            var retorno = await _context.Update(obj);
//            return retorno;
//        }
//    }
//}
