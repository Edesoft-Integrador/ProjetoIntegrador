using Microsoft.EntityFrameworkCore;
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seq.Infra.Data.Repositories
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

            return await _context.Arquivo.FromSqlRaw(sql).AsNoTracking().ToListAsync(); 
        }

        public async Task<IEnumerable> SearchTeste(long? id, string descricao)
        {
            if (id != null ^ descricao != null)
            {
                if (id != null && descricao == null)
                return await _context.Arquivo.Where(x => x.ArquivoId == Convert.ToInt64(id))
                                             .AsNoTracking().ToListAsync();

                if (id == null && descricao != null)
                    return await _context.Arquivo.Where(x => x.Descricao.ToUpper() == descricao.ToUpper())
                                                 .AsNoTracking().ToListAsync();
            }

            return await _context.Arquivo.AsNoTracking().ToListAsync();
        }
    }
}
