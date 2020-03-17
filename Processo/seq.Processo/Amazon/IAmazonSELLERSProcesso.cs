using seq.Domain.Entities;
using seq.Domain.Entities.Sellers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace seq.Processo
{
    public interface IAmazonSELLERSProcesso
    {
        Task Processa(transmission trans, string nomeArquivo, string descricao);
    }
}
