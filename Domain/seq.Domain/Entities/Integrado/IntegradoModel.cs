using seq.Domain.Interface.Entities.Integrado;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Integrado
{
    public class IntegradoModel : IIntegradoModel
    {
        public long? IntegradoId { get; set;}
        public string Descricao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public long? UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public long UsuarioIdInclusao { get; set;}
    }
}
