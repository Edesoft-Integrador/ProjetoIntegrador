﻿
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using System.Threading.Tasks;

namespace seq.Domain.Services
{
    public class AmazonHeaderService : ServiceBase<AmazonHeaderModel>, IAmazonHeaderService
    {
        private readonly IAmazonHeaderRepository _repository;
        public AmazonHeaderService(IAmazonHeaderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<long> Processa(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
