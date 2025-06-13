using DevTrustTestTask.Middlewares;

namespace DevTrustTestTask.Utils;

public static class MiddlewareProviderExtension
{
    public static void UseDevTrustTestTaskMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<DevTrustTestTaskMiddleware>();
    }
}
