using seq.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using seq.Domain.Entities.LUFT;

namespace seq.Processo
{
    public interface IAmazonLUFTProcesso
    {
        Task<IEnumerable<GeralHeaderModel>> Header(transmission trans, Guid headerIdPai, string nomeArquivo);
        Task<IEnumerable<GeralDetalheModel>> Detalhe(transmission trans, Guid headerIdPai);
    }
}
