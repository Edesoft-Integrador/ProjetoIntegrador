using seq.Domain.Interface.Entities.Arquivo;
using System;

namespace seq.Domain.Entities
{
    public class ArquivoModel : IArquivoModel
    {
        public long? Id { get; set; }
        public string Descricao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public long? UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public long UsuarioIdInclusao { get; set;}
    }
}
