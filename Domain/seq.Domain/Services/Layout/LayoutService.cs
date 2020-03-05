using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;

namespace seq.Domain.Services
{
    public class LayoutService : ServiceBase<LayoutModel>, ILayoutService
    {
        private readonly ILayoutRepository _repository;
        public LayoutService(ILayoutRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
