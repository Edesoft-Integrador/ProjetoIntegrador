//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Options;
//using seq.Domain.Entities.Arquivo;
//using seq.Domain.Interface.Repository.Arquivo;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Globalization;
//using System.Text;
//using System.Threading.Tasks;
//using static seq.Infra.BancoAcesso.Geral;

//namespace seq.DataAccess.Arquivo
//{
//    public class ArquivoRepository : IArquivoRepository, IDisposable
//    {
//        public DbConexao Conexao { get; set; }

//        public ArquivoRepository(IOptions<DbConexao> conexao) 
//        {
//            this.Conexao = conexao.Value;
//        }
//        public async Task<bool> Delete(ArquivoModel obj)
//        {
//            bool retId;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Arquivo_Delete";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Id",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Id
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@return",
//                        Direction = ParameterDirection.ReturnValue
//                    });

//                    #endregion

//                    try
//                    {
//                        oCommand.ExecuteNonQuery();

//                        retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
//                    }
//                    catch (SqlException ex)
//                    {
//                        throw new Exception("Erro de SQL Server", ex);
//                    }
//                }

//                oConnection.Close();
//            }

//            return retId;
//        }

//        public void Dispose()
//        {
//            //throw new NotImplementedException();
//        }

//        public async Task<ArquivoModel> Find(ArquivoModel obj)
//        {
//            //List<ArquivoModel> lstItem =
//            //    Search(new ArquivoModel() { Id = obj.Id }).To .ToList();

//            //return lstItem.FirstOrDefault();

//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(ArquivoModel obj)
//        {
//            Int64 retId;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Arquivo_Insert";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Descricao",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Descricao
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@UsuarioInclusao",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.UsuarioIdInclusao
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@return",
//                        Direction = ParameterDirection.ReturnValue
//                    });

//                    #endregion

//                    try
//                    {
//                        oCommand.ExecuteNonQuery();

//                        retId = Convert.ToInt64(oCommand.Parameters["@return"].Value);
//                    }
//                    catch (SqlException ex)
//                    {
//                        throw new Exception("Erro de SQL Server", ex);
//                    }
//                }

//                oConnection.Close();
//            }

//            return retId;
//        }

//        public async Task<List<ArquivoModel>> Search(ArquivoModel obj)
//        {
//            List<ArquivoModel> lstRet = new List<ArquivoModel>();

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
//            }
//            return lstRet;
//        }

//        public async Task<bool> Update(ArquivoModel obj)
//        {
//            bool retId;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Arquivo_Update";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Id",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Id
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Descricao",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Descricao
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@UsuarioAlteracao",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.UsuarioIdAlteracao
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@return",
//                        Direction = ParameterDirection.ReturnValue
//                    });

//                    #endregion

//                    try
//                    {
//                        oCommand.ExecuteNonQuery();

//                        retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
//                    }
//                    catch (SqlException ex)
//                    {
//                        throw new Exception("Erro de SQL Server", ex);
//                    }
//                }

//                oConnection.Close();
//            }

//            return retId;
//        }
//    }
//}
