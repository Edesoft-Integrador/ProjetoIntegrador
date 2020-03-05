using seq.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Services
{
    public interface IAmazonHeaderService : IServiceBase<AmazonHeaderModel>
    {
        Task<Int64> Processa(string value);
    }
}
