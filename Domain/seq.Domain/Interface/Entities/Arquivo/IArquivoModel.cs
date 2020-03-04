using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Arquivo
{
    public interface IArquivoModel: IBaseMovimentoDb
    {
      long? Id { get; set; }
      string Descricao { get; set; }
      bool Ativo { get; set; }
    }
}
