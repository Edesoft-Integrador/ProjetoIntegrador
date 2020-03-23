
using seq.Domain.Interface.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace seq.Domain.Entities
{
    [Table("tb_Integrado_Arquivo")]
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
