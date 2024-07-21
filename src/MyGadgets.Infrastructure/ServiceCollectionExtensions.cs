using Microsoft.Extensions.DependencyInjection;
using MyGadgets.Domain.Repositories;

namespace MyGadgets.Infrastructure;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGadgetRepository, GadgetRepository>();

        return services;
    }
}