using seq.Domain.Entities.Geral;
using seq.Domain.Interface.Repositories;
using seq.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Infra.Data.Repositories
{
    public class GeralDetalheRepository : RepositoryBase<GeralDetalheModel>, IGeralDetalheRepository
    {
        public GeralDetalheRepository(WebDBContext context) : base(context)
        {
        }
    }
}
