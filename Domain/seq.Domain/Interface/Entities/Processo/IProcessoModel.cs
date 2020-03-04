using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Processo
{
    public interface IProcessoModel : IBaseMovimentoDb
    {
        long? ProcessoId { get; set; }
        long IntegradoId { get; set; }
        long Id { get; set; }
        long LayoutId { get; set; }
        long ClienteId { get; set; }
        long ProdutoId { get; set; }
        string Descricao { get; set; }
        bool Coleta { get; set; }
        string Host { get; set; }
        string Usuario { get; set; }
        string Senha { get; set; }
        string HostDestino { get; set; }
        string UsuarioDestino { get; set; }
        string SenhaDestino { get; set; }
        string PastaEntrada { get; set; }
        string PastaLido { get; set; }
        string PastaLidoParcial { get; set; }
        string PastaErro { get; set; }
        string MetedoGet { get; set; }
        string MetedoPost { get; set; }
        bool Exclusao { get; set; }
        bool Ativo { get; set; }
    }
}
