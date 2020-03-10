using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace seq.Infra.BancoAcesso
{
    public class Geral: DbContext
    {
        public class DbConexao
        {
            public string DefaultConnection { get; set; }
            public string Owner { get; set; }
        }
    }
}
