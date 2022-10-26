using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnboardingProject;
using OnboardingProject.Models;

namespace OnboardingProject.Controllers
{

    public class HomeController : Controller
    {
        private readonly List<PropertyModel> propertyList = new List<PropertyModel>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult AddProperty()
        {
            
            return View();
        }

        public IActionResult UpdateProperty()
        {
            return View();
        }

        public IActionResult ListProperties()
        {
            propertyList.Add(new PropertyModel("Viale F. Scaduto 10B", 105.7, new DescriptionModel("The house where I live", "La casa dove vivo", "Dom gdzie ja mieszkam"), "Laundry, Fridge, Wi-Fi, Pets, Balcony, TV"));
            propertyList.Add(new PropertyModel("Via dell'Arsenale 132", 492.2, new DescriptionModel("My old home", "Mia vecchia casa", "Mòj stary dom"), "Fridge, Wi-Fi"));

            ViewBag.propertyList = propertyList;
            return View();
        }

        public IActionResult DeleteProperty()
        {
            return View();
        }

        public IActionResult PropertyDescription()
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