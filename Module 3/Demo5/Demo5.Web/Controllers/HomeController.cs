using Demo5.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Demo5.Web.Controllers
{
    // 1. Add log calls
    // 2. Run program on Console

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Demo5 - Constructor");
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index information");
            _logger.LogDebug("Index debug");
            _logger.LogWarning("Index Warning");
            _logger.LogCritical("Index Critical");

            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Demo5 - Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
