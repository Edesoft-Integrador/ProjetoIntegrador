using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using seq.Infra.Data.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace seq.Infra.Data.Repositories
{
    public class ArquivoRepository : RepositoryBase<ArquivoModel>, IArquivorepository
    {
        string connectionString = @"Data Source=10.0.0.229;Initial Catalog=DB_Integrador;Persist Security Info=True;User ID=wimp;Password=c14n11g2000;Connect Timeout=30000";

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

        public async Task<IEnumerable> SearchTesteADO(long? id, string descricao)
        {
            List<ArquivoModel> lstArquivo = new List<ArquivoModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                id = id.HasValue ? id : 0;

                SqlCommand cmd = new SqlCommand($"EXECUTE dbo.usp_Integrado_Arquivo_Search @ArquivoId={id}, @Descricao='{descricao}'", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lstArquivo.Add(new ArquivoModel()
                    {
                        ArquivoId = Convert.ToInt64(rdr["ArquivoId"]),
                        Descricao = rdr["Descricao"].ToString(),
                        Ativo = (bool)rdr["Ativo"],
                        DataInclusao = Convert.ToDateTime(rdr["DataInclusao"]),
                        DataAlteracao = rdr["DataAlteracao"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(rdr["DataAlteracao"]) : null,
                        UsuarioIdAlteracao = rdr["UsuarioIdAlteracao"].ToString(),
                        UsuarioIdInclusao = rdr["UsuarioIdInclusao"].ToString(),

                    });
                }
                con.Close();
            }
            return lstArquivo;
        }
    }
}
