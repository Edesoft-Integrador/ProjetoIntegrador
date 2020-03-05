using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static seq.Infra.BancoAcesso.Geral;
using seq.Infra.Data.Repository;
using seq.Domain.Services;
using Microsoft.EntityFrameworkCore;
using seq.Infra.Data.Context;
using seq.Domain.Interface.Services;
using seq.Domain.Interface.Repositories;
using seq.Applications.Services;
using seq.Application.Interfaces;

namespace IntegradorApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();


            services.Configure<DbConexao>(Configuration.GetSection("ConnectionStrings"));

            services.AddDbContext<WebDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDeparaAppService, DeparaAppService>();
            services.AddScoped<ILayoutAppService, LayoutAppService>();
            services.AddScoped<IProcessoAppService, ProcessoAppService>();
            services.AddScoped<IIntegradoAppService, IntegradoAppService>();
            services.AddScoped<IArquivoAppService, ArquivoAppService>();
            services.AddScoped<IAmazonHeaderAppService, AmazonHeaderAppService>();
            services.AddScoped<IAmazonDetalheAppService, AmazonDetalheAppService>();
            services.AddScoped<IAmazonLUFTAppService, AmazonLUFTAppService>();
            services.AddScoped<IAmazonSellersAppService, AmazonSellersAppService>();

            services.AddScoped<IDeparaService, DeparaService>();
            services.AddScoped<ILayoutService, LayoutService>();
            services.AddScoped<IProcessoService, ProcessoService>();
            services.AddScoped<IIntegradoService, IntegradoService>();
            services.AddScoped<IArquivoService, ArquivoService>();
            services.AddScoped<IAmazonHeaderService, AmazonHeaderService>();
            services.AddScoped<IAmazonDetalheService, AmazonDetalheService>();
            services.AddScoped<IAmazonLUFTService, AmazonLUFTService>();
            services.AddScoped<IAmazonSellersService, AmazonSellersService>();

            services.AddScoped<IDeparaRepository, DeparaRepository>();
            services.AddScoped<ILayoutRepository, LayoutRepository>();
            services.AddScoped<IProcessoRepository, ProcessoRepository>();
            services.AddScoped<IIntegradoRepository, IntegradoRepository>();
            services.AddScoped<IArquivorepository, ArquivoRepository>();
            services.AddScoped<IAmazonHeaderRepository, AmazonHeaderRepository>();
            services.AddScoped<IAmazonDetalheRepository, AmazonDetalheRepository>();
            services.AddScoped<IAmazonLUFTRepository, AmazonLUFTRepository>();
            services.AddScoped<IAmazonSellersRepository, AmazonSellersRepository>();

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
