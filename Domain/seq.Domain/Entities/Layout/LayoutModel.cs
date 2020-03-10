using seq.Domain.Interface.Entities.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace seq.Domain.Entities
{
    public class LayoutModel : ILayoutModel
    {
        [Key]
        public long? LayoutId { get; set;}
        public string Descricao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public string UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public string UsuarioIdInclusao { get; set;}
    }
}
