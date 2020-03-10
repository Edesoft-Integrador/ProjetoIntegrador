using seq.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using seq.Domain.Entities.LUFT;

namespace seq.Processo.Amazon
{
    public interface IAmazonLUFTProcesso
    {
        Task<IEnumerable<AmazonHeaderModel>> Header(transmission trans, Guid headerIdPai, string nomeArquivo);
        Task<IEnumerable<AmazonDetalheModel>> Detalhe(transmission trans, Guid headerIdPai);
    }
}
