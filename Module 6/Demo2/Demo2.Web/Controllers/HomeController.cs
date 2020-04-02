using Demo2.Web.Data;
using Demo2.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace Demo2.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PetCenterContext _dbContext;

        // 1. Inject PetCenterContext
        public HomeController(ILogger<HomeController> logger, PetCenterContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            // 2. Add objects and save

            var address = new Address
            {
                Street = "Streetová",
                City = "Prague"
            };

            var pet = new Pet
            {
                Name = "Scoob"
            };

            var pets = new List<Pet>
            {
                pet
            };

            var person = new Person
            {
                Name = "Bob",
                Address = address,
                Pets = pets
            };

            _dbContext.Add(person);
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
