using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using seq.Domain.Entities.Layout;
using seq.Domain.Interface.Repository.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static seq.Infra.BancoAcesso.Geral;

namespace seq.DataAccess.Layout
{
    public class LayoutRepository: ILayoutRepository, IDisposable
    {
        public DbConexao Conexao { get; set; }

        public LayoutRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        public async Task<bool> Delete(LayoutModel obj)
        {
            bool retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Layout_Delete";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@LayoutId",
                        Direction = ParameterDirection.Input,
                        Value = obj.LayoutId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@return",
                        Direction = ParameterDirection.ReturnValue
                    });

                    #endregion

                    try
                    {
                        oCommand.ExecuteNonQuery();

                        retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Erro de SQL Server", ex);
                    }
                }

                oConnection.Close();
            }

            return retId;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<LayoutModel> Find(LayoutModel obj)
        {
            //List<LayoutModel> lstItem =
            //    Search(new LayoutModel() { LayoutId = obj.LayoutId }).To .ToList();

            //return lstItem.FirstOrDefault();

            throw new NotImplementedException();
        }

        public async Task<long> Insert(LayoutModel obj)
        {
            Int64 retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Layout_Insert";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Descricao",
                        Direction = ParameterDirection.Input,
                        Value = obj.Descricao
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@UsuarioInclusao",
                        Direction = ParameterDirection.Input,
                        Value = obj.UsuarioIdInclusao
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@return",
                        Direction = ParameterDirection.ReturnValue
                    });

                    #endregion

                    try
                    {
                        oCommand.ExecuteNonQuery();

                        retId = Convert.ToInt64(oCommand.Parameters["@return"].Value);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Erro de SQL Server", ex);
                    }
                }

                oConnection.Close();
            }

            return retId;
        }

        public async Task<List<LayoutModel>> Search(LayoutModel obj)
        {

            List<LayoutModel> lstRet = new List<LayoutModel>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Layout_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@LayoutId",
                        Direction = ParameterDirection.Input,
                        Value = obj.LayoutId ?? (object)DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Descricao",
                        Direction = ParameterDirection.Input,
                        Value = obj.Descricao ?? (object)DBNull.Value
                    });

                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            LayoutModel item = new LayoutModel
                            {
                                LayoutId = oDr.IsDBNull(oDr.GetOrdinal("LayoutId")) ? null : (Int64?)Convert.ToInt64(oDr["LayoutId"]),
                                Descricao = oDr["Descricao"].ToString(),
                                Ativo = Convert.ToBoolean(oDr["Ativo"]),
                                UsuarioIdAlteracao = oDr.IsDBNull(oDr.GetOrdinal("UsuarioIdAlteracao")) ? null : (Int64?)Convert.ToInt64(oDr["UsuarioIdAlteracao"]),
                                DataAlteracao = oDr.IsDBNull(oDr.GetOrdinal("DataAlteracao")) ? null : (DateTime?)Convert.ToDateTime(oDr["DataAlteracao"]),
                                UsuarioIdInclusao = Convert.ToInt64(oDr["UsuarioIdInclusao"]),
                                DataInclusao = Convert.ToDateTime(oDr["DataInclusao"]),
                            };

                            lstRet.Add(item);
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Erro de SQL Server", ex);
                    }
                }

                oConnection.Close();
            }
            return lstRet;
        }

        public async Task<bool> Update(LayoutModel obj)
        {
            bool retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Layout_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@LayoutId",
                        Direction = ParameterDirection.Input,
                        Value = obj.LayoutId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Descricao",
                        Direction = ParameterDirection.Input,
                        Value = obj.Descricao
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@UsuarioAlteracao",
                        Direction = ParameterDirection.Input,
                        Value = obj.UsuarioIdAlteracao
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@return",
                        Direction = ParameterDirection.ReturnValue
                    });

                    #endregion

                    try
                    {
                        oCommand.ExecuteNonQuery();

                        retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Erro de SQL Server", ex);
                    }
                }

                oConnection.Close();
            }

            return retId;
        }
    }
}
