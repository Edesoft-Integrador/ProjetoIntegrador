
using seq.Domain.Interface.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace seq.Domain.Entities
{
    public class ArquivoModel : IBaseMovimentoDb
    {
        [Key]
        public long? ArquivoId { get; set; }
        public string Descricao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public string UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public string UsuarioIdInclusao { get; set;}
    }
}
