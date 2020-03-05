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

            //            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            //            {
            //                oConnection.Open();

            //                using (SqlCommand oCommand = oConnection.CreateCommand())
            //                {
            //                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Arquivo_Search";
            //                    oCommand.CommandType = CommandType.StoredProcedure;

            //                    #region --- Parâmetros ---
            //                    oCommand.Parameters.Clear();

            //                    oCommand.Parameters.Add(new SqlParameter()
            //                    {
            //                        ParameterName = "@ArquivoId",
            //                        Direction = ParameterDirection.Input,
            //                        Value = obj.Id ?? (object)DBNull.Value
            //                    });

            //                    oCommand.Parameters.Add(new SqlParameter()
            //                    {
            //                        ParameterName = "@Descricao",
            //                        Direction = ParameterDirection.Input,
            //                        Value = obj.Descricao ?? (object)DBNull.Value
            //                    });

            //                    #endregion

            //                    try
            //                    {
            //                        SqlDataReader oDr = oCommand.ExecuteReader();

            //                        while (oDr.Read())
            //                        {
            //                            ArquivoModel item = new ArquivoModel
            //                            {
            //                                Id = oDr.IsDBNull(oDr.GetOrdinal("ArquivoId")) ? null : (Int64?)Convert.ToInt64(oDr["ArquivoId"]),
            //                                Descricao = oDr["Descricao"].ToString(),
            //                                Ativo = Convert.ToBoolean(oDr["Ativo"]),
            //                                UsuarioIdAlteracao = oDr.IsDBNull(oDr.GetOrdinal("UsuarioIdAlteracao")) ? null : (Int64?)Convert.ToInt64(oDr["UsuarioIdAlteracao"]),
            //                                DataAlteracao = oDr.IsDBNull(oDr.GetOrdinal("DataAlteracao")) ? null : (DateTime?)Convert.ToDateTime(oDr["DataAlteracao"]),
            //                                UsuarioIdInclusao = Convert.ToInt64(oDr["UsuarioIdInclusao"]),
            //                                DataInclusao = Convert.ToDateTime(oDr["DataInclusao"]),
            //                            };

            //                            lstRet.Add(item);
            //                        }
            //                    }
            //                    catch (SqlException ex)
            //                    {
            //                        throw new Exception("Erro de SQL Server", ex);
            //                    }
            //                }

            //                oConnection.Close();
            return null; //_context.Arquivo.Where( x => (id != null ? x.Id == (long)id && : )
        }
    }
}
