using Demo1.Web.Data;
using Demo1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Demo1.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompanyDbContext _dbContext;

        // 1. Inject CompanyDbContext
        public HomeController(ILogger<HomeController> logger, CompanyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            // 2. Create an employee instance
            var employee = new Employee
            {
                Name = "John",
                Surname = "Doe",
                DateOfBirth = new DateTime(1980, 10, 10)
            };

            // 3. Add employee to context
            _dbContext.Add(employee);

            // 4. Save changes on context
            _dbContext.SaveChanges();

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
