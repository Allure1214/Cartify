using Microsoft.AspNetCore.Http;

namespace Cartify.Platform.Middleware;

public class TenantResolutionMiddleware
{
    private readonly RequestDelegate _next;

    public TenantResolutionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Extract tenant from subdomain or path
        var host = context.Request.Host.Host;
        var path = context.Request.Path.Value;

        string? tenantIdentifier = null;

        // Check subdomain (e.g., tenant1.cartify.com)
        if (host.Contains('.'))
        {
            var subdomain = host.Split('.')[0];
            if (subdomain != "www" && subdomain != "api")
            {
                tenantIdentifier = subdomain;
            }
        }
        // Check path-based tenancy (e.g., /tenant1/...)
        else if (path?.StartsWith("/tenant/") == true)
        {
            var pathSegments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (pathSegments.Length > 1)
            {
                tenantIdentifier = pathSegments[1];
            }
        }

        if (!string.IsNullOrEmpty(tenantIdentifier))
        {
            context.Items["TenantIdentifier"] = tenantIdentifier;
        }

        await _next(context);
    }
}
