using seq.Domain.Entities;
using seq.Domain.Entities.Sellers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace seq.Processo.Amazon
{
    public interface IAmazonSELLERSProcesso
    {
        Task<IEnumerable<AmazonHeaderModel>> Header(transmission trans, Guid headerIdPai, string nomeArquivo, string descricao);
        Task<IEnumerable<AmazonDetalheModel>> Detalhe(transmission trans, Guid headerIdPai);
    }
}
