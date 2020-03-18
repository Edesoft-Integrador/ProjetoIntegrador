using Microsoft.EntityFrameworkCore;
using seq.Domain.Entities;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace seq.Infra.Data.Repositories
{
    public class GeralHeaderRepository : RepositoryBase<GeralHeaderModel>, IGeralHeaderRepository
    {
        public GeralHeaderRepository(WebDBContext context) : base(context)
        {
        }
    }
}
