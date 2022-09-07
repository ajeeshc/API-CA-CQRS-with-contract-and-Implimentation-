using Contracts.Commands;
using Contracts.Queries;
using Implimentation.Applications.Services.Associations.Commands;
using Implimentation.Applications.Services.Associations.Queries;
using Contracts.Repository;
using Implimentation.Infrastructure.Associations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Implimentation.Infrastructure
{
    public static class StartUp
    {
        public static IServiceCollection AddImplimentation(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddScoped<IAssociationCommandService, AssociationCommandService>();
            services.AddScoped<IAssociationQueryService, AssociationQueryService>();
            services.AddScoped<IAssociationRepository, AssociationRepository>();
            return services;
        }
    }
}