using Microsoft.AspNetCore.Mvc;

namespace Demo1.Web.Controllers
{
    // 1. Add inheritance from Controller
    public class HomeController : Controller
    {
        // 2. Add Index action method
        public IActionResult Index()
        {
            return View();
        }
    }
}
