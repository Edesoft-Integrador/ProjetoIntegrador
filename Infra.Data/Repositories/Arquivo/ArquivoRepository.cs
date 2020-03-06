using Microsoft.EntityFrameworkCore;
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace seq.Infra.Data.Repository
{
    public class ArquivoRepository : RepositoryBase<ArquivoModel>, IArquivorepository
    {
        public ArquivoRepository(WebDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable> Search(long? id, string descricao)
        {            
            id = id.HasValue ? id : 0;
            var sql = string.Format($"EXECUTE dbo.usp_Integrado_Arquivo_Search @ArquivoId={id}, @Descricao='{descricao}'");
            return _context.Arquivo.FromSqlRaw(sql).ToList(); ;
        }
    }
}
