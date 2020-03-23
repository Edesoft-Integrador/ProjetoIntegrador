using Microsoft.EntityFrameworkCore;
using seq.Domain.Entities;

namespace seq.Infra.Data.Context
{
    public class WebDBContext : DbContext
    {
        public WebDBContext(DbContextOptions<WebDBContext> options) : base(options)
        {

        }

        public DbSet<GeralDetalheModel> GeralDetalhe { get; set; }
        public DbSet<GeralHeaderModel> GeralHeader { get; set; }
        public DbSet<LayoutModel> Layout { get; set; }
        public DbSet<ArquivoModel> Arquivo { get; set; }
        public DbSet<TipoModel> Tipo { get; set; }
        public DbSet<ProcessoModel> Processo { get; set; }
        public DbSet<DeparaModel> Depara { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }


    }
}
