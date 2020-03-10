using seq.Domain.Entities;
using seq.Domain.Entities.GRU5;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace seq.Processo.Amazon
{
    public interface IAmazonGRU5Processo
    {
        Task<IEnumerable<GeralHeaderModel>> Header(transmission trans, Guid headerIdPai, string nomeArquivo, string descricao);
        Task<IEnumerable<GeralDetalheModel>> Detalhe(transmission trans, Guid headerIdPai);
    }
}
