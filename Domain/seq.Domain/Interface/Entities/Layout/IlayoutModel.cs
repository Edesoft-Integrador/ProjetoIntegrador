using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Layout
{
    public interface ILayoutModel : IBaseMovimentoDb
    {
        long? LayoutId { get; set; }
        string Descricao { get; set; }
        bool Ativo { get; set; }

    }
}
