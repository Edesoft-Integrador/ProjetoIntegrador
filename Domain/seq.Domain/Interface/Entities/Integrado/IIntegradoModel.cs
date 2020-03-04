using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Integrado
{
    public interface IIntegradoModel: IBaseMovimentoDb
    {
      long? IntegradoId { get; set; }
      string Descricao { get; set; }
      bool Ativo { get; set; }
    }
}
