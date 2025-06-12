using DevTrustTestTask.Infrastructure.Interfaces;
using DevTrustTestTask.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DevTrustTestTask.Infrastructure.Utils;

public static class ServiceProviderExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IPeopleService, PeopleService>();
    }
}
