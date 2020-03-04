using seq.Domain.Interface.Entities.Layout;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Layout
{
    public class LayoutModel : ILayoutModel
    {
        public long? LayoutId { get; set;}
        public string Descricao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public long? UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public long UsuarioIdInclusao { get; set;}
    }
}
