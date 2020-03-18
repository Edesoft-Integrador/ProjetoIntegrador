
//using Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using seq.Application.Interfaces;
using seq.Application.Services;
using seq.Domain.Interface.Repositories;
using seq.Domain.Interface.Services;
using seq.Domain.Services;
using seq.Infra.CrossCutting.Email;
using seq.Infra.Data.Repositories;
using seq.Processo;

namespace seq.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //MapperConfiguration configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new AutoMapperProfileConfiguration());
            //});

            //services.AddSingleton(typeof(IMapper), configuration.CreateMapper());

            services.AddTransient<IEmailSender, EmailSender>();

            services.AddScoped<IDeparaAppService, DeparaAppService>();
            services.AddScoped<ILayoutAppService, LayoutAppService>();
            services.AddScoped<IProcessoAppService, ProcessoAppService>();
            services.AddScoped<ITipoAppService, TipoAppService>();
            services.AddScoped<IArquivoAppService, ArquivoAppService>();

            services.AddScoped<IAmazonAppService, AmazonAppService>();

            services.AddScoped<IDeparaService, DeparaService>();
            services.AddScoped<ILayoutService, LayoutService>();
            services.AddScoped<IProcessoService, ProcessoService>();
            services.AddScoped<ITipoService, TipoService>();
            services.AddScoped<IArquivoService, ArquivoService>();
            services.AddScoped<IGeralHeaderService, GeralHeaderService>();
            services.AddScoped<IGeralDetalheService, GeralDetalheService>();

            services.AddScoped<IDeparaRepository, DeparaRepository>();
            services.AddScoped<ILayoutRepository, LayoutRepository>();
            services.AddScoped<IProcessoRepository, ProcessoRepository>();
            services.AddScoped<ITipoRepository, TipoRepository>();
            services.AddScoped<IArquivorepository, ArquivoRepository>();
            services.AddScoped<IGeralHeaderRepository, GeralHeaderRepository>();
            services.AddScoped<IGeralDetalheRepository, GeralDetalheRepository>();

            services.AddScoped<IAmazonProcessaXML, AmazonProcessaXML>();
            services.AddScoped<IAmazonGRU5Processo, AmazonGRU5Processo>();
            services.AddScoped<IAmazonLUFTProcesso, AmazonLUFTProcesso>();
            services.AddScoped<IAmazonSELLERSProcesso, AmazonSELLERSProcesso>();

        }
    }
}
