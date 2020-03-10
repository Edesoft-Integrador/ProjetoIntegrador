using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Depara
{
    public interface IDeparaModel : IBaseMovimentoDb
    {
        long? DeparaId { get; set; }
        long ProcessoId { get; set; }
        string CampoOrigem { get; set; }
        string CampoDestino { get; set; }
        string CampoTipo { get; set; }
        bool CampoObrigatorio { get; set; }
        string TabelaDestino { get; set; }
        Int32 TamanhoMinimo { get; set; }
        Int32 TamanhoMaximo { get; set; }
        double ValorMinimo { get; set; }
        double ValorMaximo { get; set; }
        bool Ativo { get; set; }
    }
}
