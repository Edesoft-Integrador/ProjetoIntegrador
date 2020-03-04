using Microsoft.Extensions.Options;
using seq.Domain.Entities.Amazon;
using seq.Domain.Interface.Repository.Amazon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static seq.Infra.BancoAcesso.Geral;

namespace seq.DataAccess.Amazon
{
    public class AmazonDetalheRepository : IAmazonDetalheRepository, IDisposable
    {
        public DbConexao Conexao { get; set; }

        public AmazonDetalheRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        public Task<bool> Delete(AmazonDetalheModel obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task<AmazonDetalheModel> Find(AmazonDetalheModel obj)
        {
            throw new NotImplementedException();
        }

        public async Task<long> Insert(AmazonDetalheModel obj)
        {
            Int64 retId;

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Integrado_Detalhe_Insert";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@HeaderId",
                        Direction = ParameterDirection.Input,
                        Value = obj.HeaderId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Linha",
                        Direction = ParameterDirection.Input,
                        Value = obj.Linha
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo001",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo001 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo002",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo002 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo003",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo003 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo004",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo004 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo005",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo005 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo006",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo006 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo007",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo007 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo008",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo008 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo009",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo009 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo010",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo010 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo011",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo011 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo012",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo012 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo013",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo013 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo014",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo014 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo015",
                        Direction = ParameterDirection.Input,
                        Value = (object) obj.Campo015 ?? DBNull.Value
                    }); ;

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo016",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo016 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo017",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo017 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo018",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo018 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo019",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo019 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo020",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo020 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo021",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo021 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo022",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo022 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo023",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo023 ?? DBNull.Value
                    });


                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo024",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo024 ?? DBNull.Value
                    });



                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo025",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo025 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo026",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo026 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo027",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo027 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo028",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo028 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo029",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo029 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo030",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo030 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo031",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo031 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo032",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo032 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo033",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo033 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo034",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo034 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo035",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo035 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo036",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo036 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo037",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo037 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo038",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo038 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo039",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo039 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo040",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo040 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo041",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo041 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo042",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo042 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo043",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo043 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo044",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo044 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo045",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo045 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo046",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo046 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo047",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo047 ?? DBNull.Value
                    });
                    
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo048",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo048 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo049",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo049 ?? DBNull.Value
                    });


                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo050",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo050 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo051",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo051 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo052",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo052 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo053",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo053 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo054",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo054 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo055",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo055 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo056",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo056 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo057",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo057 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo058",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo058 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo059",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo059 ?? DBNull.Value
                    });


                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo060",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo060 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo061",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo061 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo062",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo062 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo063",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo063 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo064",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo064 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo065",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo065 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo066",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo066 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo067",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo067 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo068",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo068 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo069",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo069 ?? DBNull.Value
                    });



                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo070",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo070 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo071",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo071 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo072",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo072 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo073",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo073 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo074",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo074 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo075",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo075 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo076",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo076 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo077",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo077 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo078",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo078 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo079",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo079 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo080",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo080 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo081",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo081 ?? DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Campo082",
                        Direction = ParameterDirection.Input,
                        Value = (object)obj.Campo082 ?? DBNull.Value
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

        public Task<List<AmazonDetalheModel>> Search(AmazonDetalheModel obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(AmazonDetalheModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
