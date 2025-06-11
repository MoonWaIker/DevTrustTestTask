using DevTrustTestTask.DataBase.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevTrustTestTask.DataBase.Utils;

public static class DBContextProviderExtension
{
    private const string ConnectionStringKey = "DefaultConnection";
    private const string ConnectionStringErrorMessage = $"Connection string '{ConnectionStringKey}' not found in appsettings.json configuration.";

    public static void AddDbContext(this IServiceCollection services)
    {
        var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
        string connectionString = configuration.GetConnectionString(ConnectionStringKey)
                                    ?? throw new InvalidOperationException(ConnectionStringErrorMessage);

        services.AddDbContext<DevTrustTestTaskContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }
}
