using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Amazon
{
    public interface IAmazonLUFTDetalheModel
    {
        string cnpjCpfDestinatario { get; set; } //Campo002
        string nomeDestinatario { get; set; } //Campo003
        string logradouro { get; set; } //Campo04
        string lognumero { get; set; } //Campo22 Original no xml é "numero" para não chocar com o numero da nota coloquei log na frente
        string complemento { get; set; } //Campo005
        string bairro { get; set; } //Campo23
        string cep { get; set; } //Campo008
        string cidade { get; set; } //Campop006
        string estado { get; set; } //Campo007
        string telefone { get; set; } //Campo011
        string numero { get; set; } //Campo013
        string serie { get; set; } //Campo014
        string dataHoraEmissao { get; set; } //Campo016
        string numeroPedido { get; set; } //Campo020
        string quantidadeVolumes { get; set; } //Campo017
        string valortotalNfe { get; set; } //Campo021
        string pesoBruto { get; set; } //Campo018
        string chaveAcesso { get; set; } //Campo015
        string icmsTransporte { get; set; } //Campo024
    }
}
