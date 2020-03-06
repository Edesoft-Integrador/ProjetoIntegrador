using seq.Domain.Interface.Entities.Arquivo;
using System;
using System.ComponentModel.DataAnnotations;

namespace seq.Domain.Entities
{
    public class ArquivoModel : IArquivoModel
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
