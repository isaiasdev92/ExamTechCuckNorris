

using ExamenTech.Application.Contracts;
using ExamenTech.Application.Models;
using ExamenTech.Infrastructure.Services.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamenTech.Infrastructure.Services{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServiceChuckNorrisSettings>(configuration.GetSection("DTOneSettings"));

            services.AddTransient<IChuckNorrisRepository, ChuckNorrisRepository>();

            return services;
        }
    }
}
