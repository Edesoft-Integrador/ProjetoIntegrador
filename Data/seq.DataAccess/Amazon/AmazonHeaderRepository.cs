//using Microsoft.Extensions.Options;
//using seq.Domain.Entities.Amazon;
//using seq.Domain.Interface.Repository.Amazon;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Text;
//using System.Threading.Tasks;
//using static seq.Infra.BancoAcesso.Geral;

//namespace seq.DataAccess.Amazon
//{
//    public class AmazonHeaderRepository : IAmazonHeaderRepository, IDisposable
//    {
//        public DbConexao Conexao { get; set; }

//        public AmazonHeaderRepository(IOptions<DbConexao> conexao)
//        {
//            this.Conexao = conexao.Value;
//        }

//        public async Task<long> Insert(AmazonHeaderModel obj)
//        {
//            Int64 retId;

//            retId = 0;

//            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
//            {
//                oConnection.Open();

//                using (SqlCommand oCommand = oConnection.CreateCommand())
//                {
//                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Header_Insert";
//                    oCommand.CommandType = CommandType.StoredProcedure;

//                    #region --- Parâmetros ---
//                    oCommand.Parameters.Clear();

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Arquivo",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Arquivo ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Linha",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Linha ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Descricao",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Descricao ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo001",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo001 ?? DBNull.Value
//                    });



//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo002",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo002 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo003",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo003 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo004",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo004 ?? DBNull.Value
//                    });


//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo005",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo005 ?? DBNull.Value
//                    });


//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo006",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo006 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo007",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo007 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo008",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo008 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo009",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo009 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo010",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo010 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo011",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo011 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo012",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo012 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo013",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo013 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo014",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo014 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo015",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo015 ?? DBNull.Value
//                    }); ;

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo016",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo016 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo017",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo017 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo018",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo018 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo019",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo019 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo020",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo020 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo021",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo021 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo022",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo022 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo023",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo023 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo024",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo024 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo025",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo025 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo026",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo026 ?? DBNull.Value
//                    });

//                    oCommand.Parameters.Add(new SqlParameter()
//                    {
//                        ParameterName = "@Campo027",
//                        Direction = ParameterDirection.Input,
//                        Value = (object)obj.Campo027 ?? DBNull.Value
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

//        public Task<AmazonHeaderModel> Find(AmazonHeaderModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<List<AmazonHeaderModel>> Search(AmazonHeaderModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> Update(AmazonHeaderModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> Delete(AmazonHeaderModel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Dispose()
//        {
//          //  throw new NotImplementedException();
//        }
//    }
//}
