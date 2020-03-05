using seq.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Services
{
    public interface IAmazonSellersService : IServiceBase<AmazonSellersModel>
    {
        Task<Int64> Processa(string value);
    }
}
