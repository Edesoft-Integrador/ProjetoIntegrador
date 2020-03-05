using seq.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Services
{
    public interface IAmazonDetalheService : IServiceBase<AmazonDetalheModel>
    {
        Task<Int64> Processa(string value);
    }
}
