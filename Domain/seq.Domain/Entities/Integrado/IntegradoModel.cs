using seq.Domain.Interface.Entities.Integrado;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace seq.Domain.Entities
{ 
    public class IntegradoModel : IIntegradoModel
    {
        [Key]
        public long? IntegradoId { get; set;}
        public string Descricao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public string UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public string UsuarioIdInclusao { get; set;}
    }
}
