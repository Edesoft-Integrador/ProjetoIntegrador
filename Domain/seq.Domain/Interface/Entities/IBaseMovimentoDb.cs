using System;

namespace seq.Domain.Interface.Entities
{
    public interface IBaseMovimentoDb
    {
        DateTime? DataAlteracao { get; set; }
        string UsuarioIdAlteracao { get; set; }
        DateTime DataInclusao { get; set; }
        string UsuarioIdInclusao { get; set; }
    }
}
