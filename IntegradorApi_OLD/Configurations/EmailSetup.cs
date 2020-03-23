using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using seq.Infra.CrossCutting.Email;
using System;

namespace IntegradorApi.Configurations
{
    public static class EmailSetup
    {
        public static void AddEmailSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        }
    }
}
