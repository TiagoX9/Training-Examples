using DemoConfigEnv.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace DemoConfigEnv.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly WebAppSettings _webAppSettings;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IOptions<WebAppSettings> webAppSettings)
        {
            _logger = logger;
            _configuration = configuration;
            _webAppSettings = webAppSettings.Value;
        }

        public IActionResult Index()
        {
            //// Get the values
            //string language = _configuration.GetSection("WebAppSettings:Language").Value;
            //string dateFormat = _configuration.GetSection("WebAppSettings:DateFormat").Value;

            //// Get the values - Typed version
            string language = _webAppSettings.Language;
            string dateFormat = _webAppSettings.DateFormat;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
