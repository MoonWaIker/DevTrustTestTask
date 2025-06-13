using System.Globalization;

namespace DevTrustTestTask.Middlewares;

public class DevTrustTestTaskMiddleware(RequestDelegate next)
{
    private const string InternalServerErrorMessage = "An error occurred: {0}";

    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            // Call the next middleware in the pipeline
            await _next(context);
        }
        catch (Exception ex)
        {
            // Handle exceptions globally
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await context.Response.WriteAsync(string.Format(CultureInfo.InvariantCulture, InternalServerErrorMessage, ex.Message));
        }
    }
}
