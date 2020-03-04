using System;
using seq.Domain.Interface.Entities.Amazon;

namespace seq.Domain.Entities.Amazon
{
    public class AmazonModel : IAmazonModel
    {
        public DateTime? DataAlteracao {get; set; }
        public long? UsuarioIdAlteracao { get; set; }
        public DateTime DataInclusao { get; set;}
        public long UsuarioIdInclusao { get; set;}
        public string UsuarioInclusao { get; set; }
        public string UsuarioAlteracao { get; set; }
    }
}