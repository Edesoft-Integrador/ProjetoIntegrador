using seq.Domain.Interface.Entities.Depara;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Depara
{
    public class DeparaModel : IDeparaModel
    {
        public long? DeparaId { get; set;}
        public long ProcessoId { get; set;}
        public string CampoOrigem { get; set;}
        public string CampoDestino { get; set;}
        public string CampoTipo { get; set;}
        public bool CampoObrigatorio { get; set;}
        public string TabelaDestino { get; set;}
        public int TamanhoMinimo { get; set;}
        public int TamanhoMaximo { get; set;}
        public double ValorMinimo { get; set;}
        public double ValorMaximo { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public long? UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public long UsuarioIdInclusao { get; set;}
    }
}
