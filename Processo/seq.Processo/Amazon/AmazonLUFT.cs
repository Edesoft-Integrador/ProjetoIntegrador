using seq.Domain.Entities;
using seq.Domain.Entities.Geral;
using seq.Domain.Interface.Repositories;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace seq.Processo.Amazon
{
    public class AmazonLUFT
    {
        private readonly IGeralHeaderRepository _contextHeader;
        private readonly IGeralDetalheRepository _contextDetalhe;

        public AmazonLUFT(IGeralHeaderRepository contextHeader, IGeralDetalheRepository contextDetalhe)
        {
            _contextHeader = contextHeader;
            _contextDetalhe = contextDetalhe;
        }
        public async Task<bool> Processa(string value, string arquivo, string id, string pasta)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(AmazonLUFTModel.transmission));
                AmazonLUFTModel.transmission lista;
                using (Stream reader = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    lista = (AmazonLUFTModel.transmission)ser.Deserialize(reader);
                }

                var GeralHeaderModel = new GeralHeaderModel()
                {
                    HeaderIdPai = 0,
                    Arquivo = Path.GetFileName(value),
                    Linha = 0,
                    Descricao = pasta + " - " + arquivo + " - " + id,
                    Campo001 = "cnpjRemetente",
                    Campo002 = "inscricaoestadual",
                    Campo003 = "razaosocial",
                    Campo004 = "endereco",
                    Campo005 = "bairro",
                    Campo006 = "cidade",
                    Campo007 = "uf",
                    Campo008 = "cep"
                };

                var headerId = await _contextHeader.AddAsync(GeralHeaderModel);

                var GeralHeaderModel1 = new GeralHeaderModel()
                {
                    HeaderIdPai = headerId,
                    Arquivo = Path.GetFileName(value),
                    Linha = 1,
                    Descricao = pasta + " - " + arquivo + " - " + id,
                    Campo001 = lista.message.TrackingInfo.coletaDetalhe.cnpjRemetente,
                    Campo002 = "206319534110",
                    Campo003 = "AMAZON SERVICOS DE VAREJO DO BRASIL LTDA",
                    Campo004 = "Estrada dos Alpes, 970",
                    Campo005 = "Jardim Belval",
                    Campo006 = "BARUERI",
                    Campo007 = "SP",
                    Campo008 = "06423080",
                };

                headerId = await _contextHeader.AddAsync(GeralHeaderModel1);

                GeralDetalheModel geralDetalheModel = new GeralDetalheModel()
                {
                    HeaderId = headerId,
                    Linha = 0,
                    Campo001 = "cnpjDepositante",
                    Campo002 = "cnpjRemetente",
                    Campo003 = "numeroColeta",
                    Campo004 = "quantidadeVolumes",
                    Campo005 = "pesoBruto",
                    Campo006 = "cubagemTotal",
                    Campo007 = "quantidadeNotasFiscais",
                    Campo008 = "rgMotorista",
                    Campo009 = "nomeMotorista",
                    Campo010 = "placaVeiculo",
                    Campo011 = "dataLiberacao",
                    Campo012 = "dataEmbarque",
                    Campo013 = "embarqueLiberado",
                    Campo014 = "cnpjCpfDestinatario",
                    Campo015 = "numero",
                    Campo016 = "serie",
                    Campo017 = "chaveAcesso",
                    Campo018 = "numeroPedido",
                    Campo019 = "quantidadeVolumes",
                    Campo020 = "pesoBruto",
                    Campo021 = "pesoBrutoUM",
                    Campo022 = "cubagemTotal",
                    Campo023 = "cubagemTotalUM",
                    Campo024 = "nomeDestinatario",
                    Campo025 = "enderecoDestinatario.logradouro",
                    Campo026 = "enderecoDestinatario.numero",
                    Campo027 = "enderecoDestinatario.complemento",
                    Campo028 = "enderecoDestinatario.bairro",
                    Campo029 = "enderecoDestinatario.cep",
                    Campo030 = "enderecoDestinatario.cidade",
                    Campo031 = "enderecoDestinatario.estado",
                    Campo032 = "enderecoDestinatario.telefone",
                    Campo033 = "baseDeCalculoICMSST.amount",
                    Campo034 = "valorICMSST.amount",
                    Campo035 = "baseDeCalculoICMS.amount",
                    Campo036 = "valorTotalICMS.amount",
                    Campo037 = "valorTotalProdutos.amount",
                    Campo038 = "valorTotalNfe.amount",
                    Campo039 = "valorTotalNfe",
                    Campo040 = "volume.numero",
                    Campo041 = "volume.codigoBarras",
                    Campo042 = "volume.pesoBruto",
                    Campo043 = "volume.pesoBrutoUM",
                    Campo044 = "volume.cubagemTotal",
                    Campo045 = "volume.cubagemTotalUM",
                    Campo046 = "volume.umLineares",
                    Campo047 = "volume.codrastreio",
                    Campo048 = "volume.barraVolume",
                    Campo049 = "volume.altura",
                    Campo050 = "volume.largura",
                    Campo051 = "volume.comprimento",
                    Campo052 = "icmsTransporte",
                    Campo053 = "dataHoraEmissao.dateTime",
                    Campo054 = "dataHoraEmissao",
                    Campo055 = "xTipoEmbarque",
                    Campo056 = "cTipoEmbarque",
                    Campo057 = "prodPredominante.cProd",
                    Campo058 = "prodPredominante.cEANTrib",
                    Campo059 = "prodPredominante.xProd",
                    Campo060 = "prodPredominante.CFOP",
                    Campo061 = "prodPredominante.vProd",
                };
                var detalheId = await _contextDetalhe.AddAsync(GeralDetalheModel);

                foreach (var subitem in lista.message.TrackingInfo.coletaDetalhe.notaFiscal)
                {
                    var detalhes = new GeralDetalheModel()
                    {
                        HeaderId = headerId,
                        Linha = 1,
                        Campo001 = lista.message.TrackingInfo.coletaDetalhe.cnpjDepositante,
                        Campo002 = lista.message.TrackingInfo.coletaDetalhe.cnpjRemetente,
                        Campo003 = lista.message.TrackingInfo.coletaDetalhe.numeroColeta.ToString(),
                        Campo004 = lista.message.TrackingInfo.coletaDetalhe.quantidadeVolumes.ToString(),
                        Campo005 = lista.message.TrackingInfo.coletaDetalhe.pesoBruto.ToString(),
                        Campo006 = lista.message.TrackingInfo.coletaDetalhe.cubagemTotal.ToString(),
                        Campo007 = lista.message.TrackingInfo.coletaDetalhe.quantidadeNotasFiscais.ToString(),
                        Campo008 = lista.message.TrackingInfo.coletaDetalhe.rgMotorista.ToString(),
                        Campo009 = lista.message.TrackingInfo.coletaDetalhe.nomeMotorista.ToString(),
                        Campo010 = lista.message.TrackingInfo.coletaDetalhe.placaVeiculo.ToString(),
                        Campo011 = lista.message.TrackingInfo.coletaDetalhe.dataLiberacao.ToString(),
                        Campo012 = lista.message.TrackingInfo.coletaDetalhe.dataEmbarque.ToString(),
                        Campo013 = lista.message.TrackingInfo.coletaDetalhe.embarqueLiberado.ToString(),
                        Campo014 = subitem.cnpjCpfDestinatario.ToString(),
                        Campo015 = subitem.numero.ToString(),
                        Campo016 = subitem.serie.ToString(),
                        Campo017 = subitem.chaveAcesso.ToString(),
                        Campo018 = subitem.numeroPedido.ToString(),
                        Campo019 = subitem.quantidadeVolumes.ToString(),
                        Campo020 = subitem.pesoBruto.ToString(),
                        Campo021 = subitem.pesoBrutoUM.ToString(),
                        Campo022 = subitem.cubagemTotal.ToString(),
                        Campo023 = subitem.cubagemTotalUM.ToString(),
                        Campo024 = subitem.nomeDestinatario.ToString(),
                        Campo025 = subitem.enderecoDestinatario.logradouro.ToString(),
                        Campo026 = subitem.enderecoDestinatario.numero.ToString(),
                        Campo027 = subitem.enderecoDestinatario.complemento.ToString(),
                        Campo028 = subitem.enderecoDestinatario.bairro.ToString(),
                        Campo029 = subitem.enderecoDestinatario.cep.ToString(),
                        Campo030 = subitem.enderecoDestinatario.cidade.ToString(),
                        Campo031 = subitem.enderecoDestinatario.estado.ToString(),
                        Campo032 = subitem.enderecoDestinatario.telefone.ToString(),
                        Campo033 = subitem.baseDeCalculoICMSST.amount.ToString(),
                        Campo034 = subitem.valorICMSST.amount.ToString(),
                        Campo035 = subitem.baseDeCalculoICMS.amount.ToString(),
                        Campo036 = subitem.valorTotalICMS.amount.ToString(),
                        Campo037 = subitem.valorTotalProdutos.amount.ToString(),
                        Campo038 = subitem.valorTotalNfe.amount.ToString(),
                        Campo039 = subitem.valorTotalNfe.ToString(),
                        Campo040 = subitem.volume.numero.ToString(),
                        Campo041 = subitem.volume.codigoBarras.ToString(),
                        Campo042 = subitem.volume.pesoBruto.ToString(),
                        Campo043 = subitem.volume.pesoBrutoUM.ToString(),
                        Campo044 = subitem.volume.cubagemTotal.ToString(),
                        Campo045 = subitem.volume.cubagemTotalUM.ToString(),
                        Campo046 = subitem.volume.umLineares.ToString(),
                        Campo047 = subitem.volume.codrastreio.ToString(),
                        Campo048 = subitem.volume.barraVolume.ToString(),
                        Campo049 = subitem.volume.altura.ToString(),
                        Campo050 = subitem.volume.largura.ToString(),
                        Campo051 = subitem.volume.comprimento.ToString(),
                        Campo052 = subitem.icmsTransporte.ToString(),
                        Campo053 = subitem.dataHoraEmissao.dateTime.ToString(),
                        Campo054 = subitem.dataHoraEmissao.ToString(),
                        Campo055 = subitem.xTipoEmbarque.ToString(),
                        Campo056 = subitem.cTipoEmbarque.ToString(),
                        Campo057 = subitem.prodPredominante.cProd.ToString(),
                        Campo058 = subitem.prodPredominante.cEANTrib.ToString(),
                        Campo059 = subitem.prodPredominante.xProd.ToString(),
                        Campo060 = subitem.prodPredominante.CFOP.ToString(),
                        Campo061 = subitem.prodPredominante.vProd.ToString(),
                    };
                    await _contextDetalhe.AddAsync(detalhes);
                };
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }
    }
}