using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using seq.Application.Arquivo;
using seq.Application.Integrado;
using seq.Application.Amazon;
using seq.DataAccess.Arquivo;
using seq.DataAccess.Integrado;
using seq.DataAccess.Amazon;
using seq.Domain.Interface.Application.Arquivo;
using seq.Domain.Interface.Application.Integrado;
using seq.Domain.Interface.Application.Amazon;
using seq.Domain.Interface.Repository.Arquivo;
using seq.Domain.Interface.Repository.Integrado;
using seq.Domain.Interface.Repository.Amazon;
using static seq.Infra.BancoAcesso.Geral;


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

            services.AddScoped<IIntegradoAppService, IntegradoAppService>();
            services.AddScoped<IArquivoAppService, ArquivoAppService>();
            services.AddScoped<IAmazonAppService, AmazonAppService>();

            services.AddScoped<IIntegradoRepository, IntegradoRepository>();
            services.AddScoped<IArquivoRepository, ArquivoRepository>();
            services.AddScoped<IAmazonRepository, AmazonRepository>();

            services.AddScoped<IAmazonHeaderRepository, AmazonHeaderRepository>();
            services.AddScoped<IAmazonDetalheRepository, AmazonDetalheRepository>();


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
