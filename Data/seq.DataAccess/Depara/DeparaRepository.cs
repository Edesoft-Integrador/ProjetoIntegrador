using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using seq.Domain.Entities.Depara;
using seq.Domain.Interface.Repository.Depara;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static seq.Infra.BancoAcesso.Geral;

namespace seq.DataAccess.Depara
{
    public class DeparaRepository : IDeparaRepository, IDisposable
    {
        public DbConexao Conexao { get; set; }

        public DeparaRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        public async Task<bool> Delete(DeparaModel obj)
        {
            bool retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Depara_Delete";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@DeparaId",
                        Direction = ParameterDirection.Input,
                        Value = obj.DeparaId
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

        public async Task<DeparaModel> Find(DeparaModel obj)
        {
            //List<DeparaModel> lstItem =
            //    Search(new DeparaModel() { DeparaId = obj.DeparaId }).To .ToList();

            //return lstItem.FirstOrDefault();

            throw new NotImplementedException();
        }

        public async Task<long> Insert(DeparaModel obj)
        {
            Int64 retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Depara_Insert";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ProcessoId",
                        Direction = ParameterDirection.Input,
                        Value = obj.ProcessoId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoOrigem",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoOrigem
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoDestino",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoDestino
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoTipo",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoTipo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoObrigatorio",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoObrigatorio
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@TabelaDestino",
                        Direction = ParameterDirection.Input,
                        Value = obj.TabelaDestino
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@TamanhoMinimo",
                        Direction = ParameterDirection.Input,
                        Value = obj.TamanhoMinimo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@TamanhoMaximo",
                        Direction = ParameterDirection.Input,
                        Value = obj.TamanhoMaximo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ValorMinimo",
                        Direction = ParameterDirection.Input,
                        Value = obj.ValorMinimo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ValorMaximo",
                        Direction = ParameterDirection.Input,
                        Value = obj.ValorMaximo
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

        public async Task<List<DeparaModel>> Search(DeparaModel obj)
        {

            List<DeparaModel> lstRet = new List<DeparaModel>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Depara_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@DeparaId",
                        Direction = ParameterDirection.Input,
                        Value = obj.DeparaId ?? (object)DBNull.Value
                    });

                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            DeparaModel item = new DeparaModel
                            {
                                DeparaId = oDr.IsDBNull(oDr.GetOrdinal("DeparaId")) ? null : (Int64?)Convert.ToInt64(oDr["DeparaId"]),
                                ProcessoId = Convert.ToInt64(oDr["ProcessoId"]),
                                CampoOrigem = oDr["CampoOrigem"].ToString(),
                                CampoDestino = oDr["CampoDestino"].ToString(),
                                CampoTipo = oDr["CampoTipo"].ToString(),
                                CampoObrigatorio = Convert.ToBoolean(oDr["CampoObrigatorio"]),
                                TabelaDestino = oDr["TabelaDestino"].ToString(),
                                TamanhoMinimo = Convert.ToInt32(oDr["TamanhoMinimo"]),
                                TamanhoMaximo = Convert.ToInt32(oDr["TamanhoMaximo"]),
                                ValorMinimo = Convert.ToDouble(oDr["ValorMinimo"]),
                                ValorMaximo = Convert.ToDouble(oDr["ValorMaximo"]),
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

        public async Task<bool> Update(DeparaModel obj)
        {
            bool retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Depara_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@DeparaId",
                        Direction = ParameterDirection.Input,
                        Value = obj.DeparaId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ProcessoId",
                        Direction = ParameterDirection.Input,
                        Value = obj.ProcessoId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoOrigem",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoOrigem
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoDestino",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoDestino
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoTipo",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoTipo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CampoObrigatorio",
                        Direction = ParameterDirection.Input,
                        Value = obj.CampoObrigatorio
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@TabelaDestino",
                        Direction = ParameterDirection.Input,
                        Value = obj.TabelaDestino
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@TamanhoMinimo",
                        Direction = ParameterDirection.Input,
                        Value = obj.TamanhoMinimo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@TamanhoMaximo",
                        Direction = ParameterDirection.Input,
                        Value = obj.TamanhoMaximo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ValorMinimo",
                        Direction = ParameterDirection.Input,
                        Value = obj.ValorMinimo
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ValorMaximo",
                        Direction = ParameterDirection.Input,
                        Value = obj.ValorMaximo
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
