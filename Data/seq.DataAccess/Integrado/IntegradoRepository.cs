//using eim.Domain.Interface.Repository;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Options;
//using seq.Domain.Entities.Integrado;
//using seq.Domain.Interface.Repositories.Integrado;
//using seq.Domain.Interface.Repository.Integrado;
//using seq.Infra.BancoAcesso;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Text;
//using System.Threading.Tasks;
//using static seq.Infra.BancoAcesso.Geral;

//namespace seq.DataAccess.Integrado
//{
//    public class IntegradoRepository : IIntegradoRepository, IDisposable
//    {
//        public DbConexao Conexao { get; set; }

//        public IntegradoRepository(IOptions<DbConexao> conexao)
//        {
//            this.Conexao = conexao.Value;
//        }
//        public async Task<bool> Delete(IntegradoModel obj)
//       {
//           bool retId;

//           using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//           {
//               oConnection.Open();

//               using (SqlCommand oCommand = oConnection.CreateCommand())
//               {
//                   oCommand.CommandText = Conexao.Owner + "usp_Integrado_Delete";
//                   oCommand.CommandType = CommandType.StoredProcedure;

//                   #region --- Parâmetros ---
//                   oCommand.Parameters.Clear();

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@IntegradoId",
//                       Direction = ParameterDirection.Input,
//                       Value = obj.IntegradoId
//                   });

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@return",
//                       Direction = ParameterDirection.ReturnValue
//                   });

//                   #endregion

//                   try
//                   {
//                       oCommand.ExecuteNonQuery();

//                       retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
//                   }
//                   catch (SqlException ex)
//                   {
//                       throw new Exception("Erro de SQL Server", ex);
//                   }
//               }

//               oConnection.Close();
//           }

//           return retId;
//       }

//       public void Dispose()
//       {
//           //throw new NotImplementedException();
//       }

//       public async Task<IntegradoModel> Find(IntegradoModel obj)
//       {
//            //List<IntegradoModel> lstItem =
//            //    Search(new IntegradoModel() { IntegradoId = obj.IntegradoId }).To .ToList();

//            //return lstItem.FirstOrDefault();

//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(IntegradoModel obj)
//       {
//           Int64 retId;

//           using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//           {
//               oConnection.Open();

//               using (SqlCommand oCommand = oConnection.CreateCommand())
//               {
//                   oCommand.CommandText = Conexao.Owner + "usp_Integrado_Insert";
//                   oCommand.CommandType = CommandType.StoredProcedure;

//                   #region --- Parâmetros ---
//                   oCommand.Parameters.Clear();

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@Descricao",
//                       Direction = ParameterDirection.Input,
//                       Value = obj.Descricao
//                   });

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@UsuarioInclusao",
//                       Direction = ParameterDirection.Input,
//                       Value = obj.UsuarioIdInclusao
//                   });

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@return",
//                       Direction = ParameterDirection.ReturnValue
//                   });

//                   #endregion

//                   try
//                   {
//                       oCommand.ExecuteNonQuery();

//                       retId = Convert.ToInt64(oCommand.Parameters["@return"].Value);
//                   }
//                   catch (SqlException ex)
//                   {
//                       throw new Exception("Erro de SQL Server", ex);
//                   }
//               }

//               oConnection.Close();
//           }

//           return retId;
//       }

//       public async Task<List<IntegradoModel>> Search(IntegradoModel obj)
//       {
//            List<IntegradoModel> lstRet = new List<IntegradoModel>();
            
//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Search";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@IntegradoId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.IntegradoId ?? (object)DBNull.Value
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
//                            IntegradoModel item = new IntegradoModel
//                            {
//                                IntegradoId = oDr.IsDBNull(oDr.GetOrdinal("IntegradoId")) ? null : (Int64?)Convert.ToInt64(oDr["IntegradoId"]),
//                                Descricao = oDr["Descricao"].ToString(),
//                                Ativo = Convert.ToBoolean(oDr["Ativo"]),
//                                // UsuarioIdAlteracao = oDr.IsDBNull(oDr.GetOrdinal("UsuarioIdAlteracao")) ? null : (Int64?)Convert.ToInt64(oDr["UsuarioIdAlteracao"]),
//                                // DataAlteracao = oDr.IsDBNull(oDr.GetOrdinal("DataAlteracao")) ? null : (DateTime?)Convert.ToDateTime(oDr["DataAlteracao"]),
//                                // UsuarioIdInclusao = Convert.ToInt64(oDr["UsuarioIdInclusao"]),
//                                // DataInclusao = Convert.ToDateTime(oDr["DataInclusao"]),
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

//        public async Task<bool> Update(IntegradoModel obj)
//       {
//           bool retId;

//           using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//           {
//               oConnection.Open();

//               using (SqlCommand oCommand = oConnection.CreateCommand())
//               {
//                   oCommand.CommandText = Conexao.Owner + "usp_Integrado_Update";
//                   oCommand.CommandType = CommandType.StoredProcedure;

//                   #region --- Parâmetros ---
//                   oCommand.Parameters.Clear();

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@IntegradoId",
//                       Direction = ParameterDirection.Input,
//                       Value = obj.IntegradoId
//                   });

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@Descricao",
//                       Direction = ParameterDirection.Input,
//                       Value = obj.Descricao
//                   });

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@UsuarioAlteracao",
//                       Direction = ParameterDirection.Input,
//                       Value = obj.UsuarioIdAlteracao
//                   });

//                   oCommand.Parameters.Add(new SqlParameter()
//                   {
//                       ParameterName = "@return",
//                       Direction = ParameterDirection.ReturnValue
//                   });

//                   #endregion

//                   try
//                   {
//                       oCommand.ExecuteNonQuery();

//                       retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
//                   }
//                   catch (SqlException ex)
//                   {
//                       throw new Exception("Erro de SQL Server", ex);
//                   }
//               }

//               oConnection.Close();
//           }

//           return retId;
//       }
//    }
//}
