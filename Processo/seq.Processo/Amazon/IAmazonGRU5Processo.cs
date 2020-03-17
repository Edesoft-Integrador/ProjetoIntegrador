using seq.Domain.Entities;
using seq.Domain.Entities.GRU5;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace seq.Processo
{
    public interface IAmazonGRU5Processo
    {
        Task Processa(transmission trans, string nomeArquivo, string descricao);
    }
}
