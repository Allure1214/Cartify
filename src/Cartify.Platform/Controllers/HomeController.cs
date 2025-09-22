using Microsoft.AspNetCore.Mvc;

namespace Cartify.Platform.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Get current tenant if available
        var tenantIdentifier = HttpContext.Items["TenantIdentifier"];
        
        if (tenantIdentifier != null)
        {
            // TODO: Redirect to tenant storefront when Storefront area is implemented
            // For now, show platform landing page with tenant info
            ViewBag.TenantIdentifier = tenantIdentifier;
        }

        // Show platform landing page
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
