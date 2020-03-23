//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Options;
//using seq.Domain.Entities.Processo;
//using seq.Domain.Interface.Repository.Processo;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Text;
//using System.Threading.Tasks;
//using static seq.Infra.BancoAcesso.Geral;

//namespace seq.DataAccess.Processo
//{
//    public class ProcessoRepository : IProcessoRepository, IDisposable
//    {
//        public DbConexao Conexao { get; set; }

//        public ProcessoRepository(IOptions<DbConexao> conexao)
//        {
//            this.Conexao = conexao.Value;
//        }
//        public async Task<bool> Delete(ProcessoModel obj)
//        {
//            bool retId;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Processo_Delete";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@ProcessoId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.ProcessoId
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

//        public async Task<ProcessoModel> Find(ProcessoModel obj)
//        {
//            //List<ProcessoModel> lstItem =
//            //    Search(new ProcessoModel() { ProcessoId = obj.ProcessoId }).To .ToList();

//            //return lstItem.FirstOrDefault();

//            throw new NotImplementedException();
//        }

//        public async Task<long> Insert(ProcessoModel obj)
//        {
//            Int64 retId;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Processo_Insert";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();


//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@IntegradoId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.IntegradoId
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Id",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Id
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@LayoutId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.LayoutId
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@ClienteId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.ClienteId
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@ProdutoId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.ProdutoId
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Descricao",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Descricao
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Coleta",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Coleta
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Host",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Host
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Usuario",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Usuario
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Senha",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Senha
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@HostDestino",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.HostDestino
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@UsuarioDestino",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.UsuarioDestino
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@SenhaDestino",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.SenhaDestino
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@PastaEntrada",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.PastaEntrada
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@PastaLido",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.PastaLido
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@PastaLidoParcial",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.PastaLidoParcial
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@PastaErro",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.PastaErro
//                    });


//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@MetedoGet",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.MetedoGet
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@MetedoPost",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.MetedoPost
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Exclusao",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.Exclusao
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

//        public async Task<List<ProcessoModel>> Search(ProcessoModel obj)
//        {

//            List<ProcessoModel> lstRet = new List<ProcessoModel>();

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Processo_Search";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@ProcessoId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.ProcessoId ?? (object)DBNull.Value
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
//                            ProcessoModel item = new ProcessoModel
//                            {
//                                ProcessoId = oDr.IsDBNull(oDr.GetOrdinal("ProcessoId")) ? null : (Int64?)Convert.ToInt64(oDr["ProcessoId"]),
//                                IntegradoId = Convert.ToInt64(oDr["IntegradoId"]),
//                                Id = Convert.ToInt64(oDr["Id"]),
//                                LayoutId = Convert.ToInt64(oDr["LayoutId"]),
//                                ClienteId = Convert.ToInt64(oDr["ClienteId"]),
//                                ProdutoId = Convert.ToInt64(oDr["ProdutoId"]),
//                                Descricao = oDr["Descricao"].ToString(),
//                                Coleta = Convert.ToBoolean(oDr["Coleta"]),
//                                Host = oDr["Host"].ToString(),
//                                Usuario = oDr["Usuario"].ToString(),
//                                Senha = oDr["Senha"].ToString(),
//                                HostDestino = oDr["HostDestino"].ToString(),
//                                UsuarioDestino = oDr["UsuarioDestino"].ToString(),
//                                SenhaDestino = oDr["SenhaDestino"].ToString(),
//                                PastaEntrada = oDr["PastaEntrada"].ToString(),
//                                PastaLido = oDr["PastaLido"].ToString(),
//                                PastaLidoParcial = oDr["PastaLidoParcial"].ToString(),
//                                PastaErro = oDr["PastaErro"].ToString(),
//                                MetedoGet = oDr["MetedoGet"].ToString(),
//                                MetedoPost = oDr["MetedoPost"].ToString(),
//                                Exclusao = Convert.ToBoolean(oDr["Exclusao"]),
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

//        public async Task<bool> Update(ProcessoModel obj)
//        {
//            bool retId;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Processo_Update";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@ProcessoId",
//                        Direction = ParameterDirection.Input,
//                        Value = obj.ProcessoId
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
