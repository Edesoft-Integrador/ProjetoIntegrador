using seq.Domain.Interface.Entities.Depara;
using System;
using System.ComponentModel.DataAnnotations;

namespace seq.Domain.Entities
{
    public class DeparaModel : IDeparaModel
    {
        [Key]
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
        public string UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public string UsuarioIdInclusao { get; set;}
    }
}
