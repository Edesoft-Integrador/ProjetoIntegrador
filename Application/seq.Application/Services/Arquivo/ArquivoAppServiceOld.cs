//using seq.Domain.Entities.Arquivo;
//using seq.Domain.Interface.Repositories.Arquivo;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace seq.Application.Arquivo
//{
//    public class ArquivoAppService //: IArquivoService
//    {
//        private readonly IArquivoRepository _context;

//        public ArquivoAppService(IArquivoRepository context)
//        {
//            _context = context;
//        }
//        public void Dispose()
//        {
//            //throw new NotImplementedException();
//        }


//        public async Task<long> Insert(ArquivoModel obj)
//        {
//            var retorno = await _context.Insert(obj);
//            return retorno;
//        }

//        public async Task<List<ArquivoModel>> Search(ArquivoModel obj)
//        {
//            var retorno = await _context.Search(obj);
//            return retorno;
//        }

//        public async Task<bool> Update(ArquivoModel obj)
//        {
//            var retorno = await _context.Update(obj);
//            return retorno;
//        }
//    }
//}
