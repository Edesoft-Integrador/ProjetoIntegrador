using Microsoft.EntityFrameworkCore;
using seq.Domain.Entities;

namespace seq.Infra.Data.Context
{
    public class WebDBContext : DbContext
    {
        public WebDBContext(DbContextOptions<WebDBContext> options) : base(options)
        {

        }

        public DbSet<AmazonDetalheModel> AmazonDetalhe { get; set; }
        public DbSet<AmazonHeaderModel> AmazonHeader { get; set; }
        //public DbSet<AmazonLUFTModel> AmazonLUFT { get; set; }
        //public DbSet<AmazonSellersModel> AmazonSellers { get; set; }
        public DbSet<LayoutModel> Layout { get; set; }
        public DbSet<ArquivoModel> Arquivo { get; set; }
        public DbSet<IntegradoModel> Integrado { get; set; }
        public DbSet<ProcessoModel> Processo { get; set; }
        public DbSet<DeparaModel> Depara { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }


    }
}
