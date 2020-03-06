using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace seq.Domain.Entities
{
    public class AmazonLUFTModel
    {


        // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class transmission
        {

            private transmissionMessage messageField;

            [Key]
            private string receivingPartyIDField;

            private uint transmissionControlNumberField;

            private System.DateTime transmissionCreationDateField;

            private decimal transmissionStructureVersionField;

            private decimal messageCountField;

            private bool isTestField;

            /// <remarks/>
            public transmissionMessage message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string receivingPartyID
            {
                get
                {
                    return this.receivingPartyIDField;
                }
                set
                {
                    this.receivingPartyIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint transmissionControlNumber
            {
                get
                {
                    return this.transmissionControlNumberField;
                }
                set
                {
                    this.transmissionControlNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime transmissionCreationDate
            {
                get
                {
                    return this.transmissionCreationDateField;
                }
                set
                {
                    this.transmissionCreationDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal transmissionStructureVersion
            {
                get
                {
                    return this.transmissionStructureVersionField;
                }
                set
                {
                    this.transmissionStructureVersionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal messageCount
            {
                get
                {
                    return this.messageCountField;
                }
                set
                {
                    this.messageCountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isTest
            {
                get
                {
                    return this.isTestField;
                }
                set
                {
                    this.isTestField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessage
        {

            private transmissionMessageTrackingInfo trackingInfoField;

            private string receivingPartyIDField;

            private uint messageControlNumberField;

            private System.DateTime messageCreationDateField;

            private decimal messageStructureVersionField;

            private string messageTypeField;

            private bool isTestField;

            /// <remarks/>
            public transmissionMessageTrackingInfo TrackingInfo
            {
                get
                {
                    return this.trackingInfoField;
                }
                set
                {
                    this.trackingInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string receivingPartyID
            {
                get
                {
                    return this.receivingPartyIDField;
                }
                set
                {
                    this.receivingPartyIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint messageControlNumber
            {
                get
                {
                    return this.messageControlNumberField;
                }
                set
                {
                    this.messageControlNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime messageCreationDate
            {
                get
                {
                    return this.messageCreationDateField;
                }
                set
                {
                    this.messageCreationDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal messageStructureVersion
            {
                get
                {
                    return this.messageStructureVersionField;
                }
                set
                {
                    this.messageStructureVersionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string messageType
            {
                get
                {
                    return this.messageTypeField;
                }
                set
                {
                    this.messageTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isTest
            {
                get
                {
                    return this.isTestField;
                }
                set
                {
                    this.isTestField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfo
        {

            private transmissionMessageTrackingInfoColetaDetalhe coletaDetalheField;

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalhe coletaDetalhe
            {
                get
                {
                    return this.coletaDetalheField;
                }
                set
                {
                    this.coletaDetalheField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalhe
        {

            private string cnpjDepositanteField;

            private string cnpjRemetenteField;

            private uint numeroColetaField;

            private decimal quantidadeVolumesField;

            private decimal pesoBrutoField;

            private decimal cubagemTotalField;

            private decimal quantidadeNotasFiscaisField;

            private string rgMotoristaField;

            private string nomeMotoristaField;

            private string placaVeiculoField;

            private System.DateTime dataLiberacaoField;

            private System.DateTime dataEmbarqueField;

            private string embarqueLiberadoField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscal[] notaFiscalField;

            /// <remarks/>
            public string cnpjDepositante
            {
                get
                {
                    return this.cnpjDepositanteField;
                }
                set
                {
                    this.cnpjDepositanteField = value;
                }
            }

            /// <remarks/>
            public string cnpjRemetente
            {
                get
                {
                    return this.cnpjRemetenteField;
                }
                set
                {
                    this.cnpjRemetenteField = value;
                }
            }

            /// <remarks/>
            public uint numeroColeta
            {
                get
                {
                    return this.numeroColetaField;
                }
                set
                {
                    this.numeroColetaField = value;
                }
            }

            /// <remarks/>
            public decimal quantidadeVolumes
            {
                get
                {
                    return this.quantidadeVolumesField;
                }
                set
                {
                    this.quantidadeVolumesField = value;
                }
            }

            /// <remarks/>
            public decimal pesoBruto
            {
                get
                {
                    return this.pesoBrutoField;
                }
                set
                {
                    this.pesoBrutoField = value;
                }
            }

            /// <remarks/>
            public decimal cubagemTotal
            {
                get
                {
                    return this.cubagemTotalField;
                }
                set
                {
                    this.cubagemTotalField = value;
                }
            }

            /// <remarks/>
            public decimal quantidadeNotasFiscais
            {
                get
                {
                    return this.quantidadeNotasFiscaisField;
                }
                set
                {
                    this.quantidadeNotasFiscaisField = value;
                }
            }

            /// <remarks/>
            public string rgMotorista
            {
                get
                {
                    return this.rgMotoristaField;
                }
                set
                {
                    this.rgMotoristaField = value;
                }
            }

            /// <remarks/>
            public string nomeMotorista
            {
                get
                {
                    return this.nomeMotoristaField;
                }
                set
                {
                    this.nomeMotoristaField = value;
                }
            }

            /// <remarks/>
            public string placaVeiculo
            {
                get
                {
                    return this.placaVeiculoField;
                }
                set
                {
                    this.placaVeiculoField = value;
                }
            }

            /// <remarks/>
            public System.DateTime dataLiberacao
            {
                get
                {
                    return this.dataLiberacaoField;
                }
                set
                {
                    this.dataLiberacaoField = value;
                }
            }

            /// <remarks/>
            public System.DateTime dataEmbarque
            {
                get
                {
                    return this.dataEmbarqueField;
                }
                set
                {
                    this.dataEmbarqueField = value;
                }
            }

            /// <remarks/>
            public string embarqueLiberado
            {
                get
                {
                    return this.embarqueLiberadoField;
                }
                set
                {
                    this.embarqueLiberadoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("notaFiscal")]
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscal[] notaFiscal
            {
                get
                {
                    return this.notaFiscalField;
                }
                set
                {
                    this.notaFiscalField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscal
        {

            private string cnpjCpfDestinatarioField;

            private uint numeroField;

            private decimal serieField;

            private string chaveAcessoField;

            private ulong numeroPedidoField;

            private decimal quantidadeVolumesField;

            private decimal pesoBrutoField;

            private string pesoBrutoUMField;

            private decimal cubagemTotalField;

            private string cubagemTotalUMField;

            private string nomeDestinatarioField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalEnderecoDestinatario enderecoDestinatarioField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalBaseDeCalculoICMSST baseDeCalculoICMSSTField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorICMSST valorICMSSTField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalBaseDeCalculoICMS baseDeCalculoICMSField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalICMS valorTotalICMSField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalProdutos valorTotalProdutosField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalNfe valorTotalNfeField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalVolume volumeField;

            private decimal icmsTransporteField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalDataHoraEmissao dataHoraEmissaoField;

            private string xTipoEmbarqueField;

            private string cTipoEmbarqueField;

            private transmissionMessageTrackingInfoColetaDetalheNotaFiscalProdPredominante prodPredominanteField;

            /// <remarks/>
            public string cnpjCpfDestinatario
            {
                get
                {
                    return this.cnpjCpfDestinatarioField;
                }
                set
                {
                    this.cnpjCpfDestinatarioField = value;
                }
            }

            /// <remarks/>
            public uint numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <remarks/>
            public decimal serie
            {
                get
                {
                    return this.serieField;
                }
                set
                {
                    this.serieField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
            public string chaveAcesso
            {
                get
                {
                    return this.chaveAcessoField;
                }
                set
                {
                    this.chaveAcessoField = value;
                }
            }

            /// <remarks/>
            public ulong numeroPedido
            {
                get
                {
                    return this.numeroPedidoField;
                }
                set
                {
                    this.numeroPedidoField = value;
                }
            }

            /// <remarks/>
            public decimal quantidadeVolumes
            {
                get
                {
                    return this.quantidadeVolumesField;
                }
                set
                {
                    this.quantidadeVolumesField = value;
                }
            }

            /// <remarks/>
            public decimal pesoBruto
            {
                get
                {
                    return this.pesoBrutoField;
                }
                set
                {
                    this.pesoBrutoField = value;
                }
            }

            /// <remarks/>
            public string pesoBrutoUM
            {
                get
                {
                    return this.pesoBrutoUMField;
                }
                set
                {
                    this.pesoBrutoUMField = value;
                }
            }

            /// <remarks/>
            public decimal cubagemTotal
            {
                get
                {
                    return this.cubagemTotalField;
                }
                set
                {
                    this.cubagemTotalField = value;
                }
            }

            /// <remarks/>
            public string cubagemTotalUM
            {
                get
                {
                    return this.cubagemTotalUMField;
                }
                set
                {
                    this.cubagemTotalUMField = value;
                }
            }

            /// <remarks/>
            public string nomeDestinatario
            {
                get
                {
                    return this.nomeDestinatarioField;
                }
                set
                {
                    this.nomeDestinatarioField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalEnderecoDestinatario enderecoDestinatario
            {
                get
                {
                    return this.enderecoDestinatarioField;
                }
                set
                {
                    this.enderecoDestinatarioField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalBaseDeCalculoICMSST baseDeCalculoICMSST
            {
                get
                {
                    return this.baseDeCalculoICMSSTField;
                }
                set
                {
                    this.baseDeCalculoICMSSTField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorICMSST valorICMSST
            {
                get
                {
                    return this.valorICMSSTField;
                }
                set
                {
                    this.valorICMSSTField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalBaseDeCalculoICMS baseDeCalculoICMS
            {
                get
                {
                    return this.baseDeCalculoICMSField;
                }
                set
                {
                    this.baseDeCalculoICMSField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalICMS valorTotalICMS
            {
                get
                {
                    return this.valorTotalICMSField;
                }
                set
                {
                    this.valorTotalICMSField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalProdutos valorTotalProdutos
            {
                get
                {
                    return this.valorTotalProdutosField;
                }
                set
                {
                    this.valorTotalProdutosField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalNfe valorTotalNfe
            {
                get
                {
                    return this.valorTotalNfeField;
                }
                set
                {
                    this.valorTotalNfeField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalVolume volume
            {
                get
                {
                    return this.volumeField;
                }
                set
                {
                    this.volumeField = value;
                }
            }

            /// <remarks/>
            public decimal icmsTransporte
            {
                get
                {
                    return this.icmsTransporteField;
                }
                set
                {
                    this.icmsTransporteField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalDataHoraEmissao dataHoraEmissao
            {
                get
                {
                    return this.dataHoraEmissaoField;
                }
                set
                {
                    this.dataHoraEmissaoField = value;
                }
            }

            /// <remarks/>
            public string xTipoEmbarque
            {
                get
                {
                    return this.xTipoEmbarqueField;
                }
                set
                {
                    this.xTipoEmbarqueField = value;
                }
            }

            /// <remarks/>
            public string cTipoEmbarque
            {
                get
                {
                    return this.cTipoEmbarqueField;
                }
                set
                {
                    this.cTipoEmbarqueField = value;
                }
            }

            /// <remarks/>
            public transmissionMessageTrackingInfoColetaDetalheNotaFiscalProdPredominante prodPredominante
            {
                get
                {
                    return this.prodPredominanteField;
                }
                set
                {
                    this.prodPredominanteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalEnderecoDestinatario
        {

            private string logradouroField;

            private string numeroField;

            private string complementoField;

            private string bairroField;

            private uint cepField;

            private string cidadeField;

            private string estadoField;

            private ulong telefoneField;

            /// <remarks/>
            public string logradouro
            {
                get
                {
                    return this.logradouroField;
                }
                set
                {
                    this.logradouroField = value;
                }
            }

            /// <remarks/>
            public string numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <remarks/>
            public string complemento
            {
                get
                {
                    return string.IsNullOrEmpty(this.complementoField) ? "" : this.complementoField;
                }
                set
                {
                    this.complementoField = value;
                }
            }

            /// <remarks/>
            public string bairro
            {
                get
                {
                    return this.bairroField;
                }
                set
                {
                    this.bairroField = value;
                }
            }

            /// <remarks/>
            public uint cep
            {
                get
                {
                    return this.cepField;
                }
                set
                {
                    this.cepField = value;
                }
            }

            /// <remarks/>
            public string cidade
            {
                get
                {
                    return this.cidadeField;
                }
                set
                {
                    this.cidadeField = value;
                }
            }

            /// <remarks/>
            public string estado
            {
                get
                {
                    return this.estadoField;
                }
                set
                {
                    this.estadoField = value;
                }
            }

            /// <remarks/>
            public ulong telefone
            {
                get
                {
                    return this.telefoneField;
                }
                set
                {
                    this.telefoneField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalBaseDeCalculoICMSST
        {

            private decimal amountField;

            /// <remarks/>
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorICMSST
        {

            private decimal amountField;

            /// <remarks/>
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalBaseDeCalculoICMS
        {

            private decimal amountField;

            /// <remarks/>
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalICMS
        {

            private decimal amountField;

            /// <remarks/>
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalProdutos
        {

            private decimal amountField;

            /// <remarks/>
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalValorTotalNfe
        {

            private decimal amountField;

            /// <remarks/>
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalVolume
        {

            private decimal numeroField;

            private string codigoBarrasField;

            private decimal pesoBrutoField;

            private string pesoBrutoUMField;

            private decimal cubagemTotalField;

            private string cubagemTotalUMField;

            private string umLinearesField;

            private string codrastreioField;

            private ulong barraVolumeField;

            private decimal alturaField;

            private decimal larguraField;

            private decimal comprimentoField;

            /// <remarks/>
            public decimal numero
            {
                get
                {
                    return this.numeroField;
                }
                set
                {
                    this.numeroField = value;
                }
            }

            /// <remarks/>
            public string codigoBarras
            {
                get
                {
                    return this.codigoBarrasField;
                }
                set
                {
                    this.codigoBarrasField = value;
                }
            }

            /// <remarks/>
            public decimal pesoBruto
            {
                get
                {
                    return this.pesoBrutoField;
                }
                set
                {
                    this.pesoBrutoField = value;
                }
            }

            /// <remarks/>
            public string pesoBrutoUM
            {
                get
                {
                    return this.pesoBrutoUMField;
                }
                set
                {
                    this.pesoBrutoUMField = value;
                }
            }

            /// <remarks/>
            public decimal cubagemTotal
            {
                get
                {
                    return this.cubagemTotalField;
                }
                set
                {
                    this.cubagemTotalField = value;
                }
            }

            /// <remarks/>
            public string cubagemTotalUM
            {
                get
                {
                    return this.cubagemTotalUMField;
                }
                set
                {
                    this.cubagemTotalUMField = value;
                }
            }

            /// <remarks/>
            public string umLineares
            {
                get
                {
                    return this.umLinearesField;
                }
                set
                {
                    this.umLinearesField = value;
                }
            }

            /// <remarks/>
            public string codrastreio
            {
                get
                {
                    return this.codrastreioField;
                }
                set
                {
                    this.codrastreioField = value;
                }
            }

            /// <remarks/>
            public ulong barraVolume
            {
                get
                {
                    return this.barraVolumeField;
                }
                set
                {
                    this.barraVolumeField = value;
                }
            }

            /// <remarks/>
            public decimal altura
            {
                get
                {
                    return this.alturaField;
                }
                set
                {
                    this.alturaField = value;
                }
            }

            /// <remarks/>
            public decimal largura
            {
                get
                {
                    return this.larguraField;
                }
                set
                {
                    this.larguraField = value;
                }
            }

            /// <remarks/>
            public decimal comprimento
            {
                get
                {
                    return this.comprimentoField;
                }
                set
                {
                    this.comprimentoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalDataHoraEmissao
        {

            private System.DateTime dateTimeField;

            /// <remarks/>
            public System.DateTime dateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class transmissionMessageTrackingInfoColetaDetalheNotaFiscalProdPredominante
        {

            private string cProdField;

            private ulong cEANTribField;

            private string xProdField;

            private ushort cFOPField;

            private decimal vProdField;

            /// <remarks/>
            public string cProd
            {
                get
                {
                    return this.cProdField;
                }
                set
                {
                    this.cProdField = value;
                }
            }

            /// <remarks/>
            public ulong cEANTrib
            {
                get
                {
                    return this.cEANTribField;
                }
                set
                {
                    this.cEANTribField = value;
                }
            }

            /// <remarks/>
            public string xProd
            {
                get
                {
                    return this.xProdField;
                }
                set
                {
                    this.xProdField = value;
                }
            }

            /// <remarks/>
            public ushort CFOP
            {
                get
                {
                    return this.cFOPField;
                }
                set
                {
                    this.cFOPField = value;
                }
            }

            /// <remarks/>
            public decimal vProd
            {
                get
                {
                    return this.vProdField;
                }
                set
                {
                    this.vProdField = value;
                }
            }
        }




    }
}
