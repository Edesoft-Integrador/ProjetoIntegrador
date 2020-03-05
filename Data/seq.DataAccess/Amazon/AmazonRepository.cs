//using Microsoft.Extensions.Options;
//using seq.Domain.Entities.Amazon;
//using seq.Domain.Interface.Repository.Amazon;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using static seq.Infra.BancoAcesso.Geral;

//namespace seq.DataAccess.Amazon
//{
//    public class AmazonRepository : IAmazonRepository, IDisposable
//    {
//        public DbConexao Conexao { get; set; }

//        public AmazonRepository(IOptions<DbConexao> conexao)
//        {
//            this.Conexao = conexao.Value;
//        }
//        public async Task<bool> Delete(AmazonModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Dispose()
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<AmazonModel> Find(AmazonModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(AmazonModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<List<AmazonModel>> Search(AmazonModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> Update(AmazonModel obj)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
