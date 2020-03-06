﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eim.Domain.Interface.Entities
{
    public interface IBaseMovimentoDb
    {
        DateTime? DataAlteracao { get; set; }
        string UsuarioIdAlteracao { get; set; }
        DateTime DataInclusao { get; set; }
        string UsuarioIdInclusao { get; set; }
    }
}
