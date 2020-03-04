using eim.Application.Interface;
using seq.Domain.Entities.Amazon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace seq.Domain.Interface.Application.Amazon
{
    public interface IAmazonAppService : IAppServiceBase<AmazonModel>
    {
        Task<Int64> Processa(string value);
    }
}
