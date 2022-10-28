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

        [HttpPost]
        public IActionResult AddPropertyMethod([FromForm] PropertyModel property)
        {
            StaticData.propertyList.Add(property);
            return RedirectToAction("ListProperties");
        }

        public IActionResult UpdateProperty(int propertyID, int index)
        {
            UpdateModel sendPackage = new UpdateModel(propertyID, index);
            return View(sendPackage);
        }

        [HttpPost]
        public IActionResult UpdatePropertyMethod([FromForm] UpdateModel updated)
        {
            
            switch (updated.index)
            {
                case 1:
                    StaticData.propertyList.Find(property => property.PropertyID.Equals(updated.propertyID)).address = updated.value;
                    break;
                case 2:
                    StaticData.propertyList.Find(property => property.PropertyID.Equals(updated.propertyID)).descriptions.englishDescription = updated.value;
                    break;
                case 3:
                    StaticData.propertyList.Find(property => property.PropertyID.Equals(updated.propertyID)).surface = Convert.ToDouble(updated.value);
                    break;
                case 4:
                    StaticData.propertyList.Find(property => property.PropertyID.Equals(updated.propertyID)).services = updated.value;
                    break;
            }
            return RedirectToAction("ListProperties");
        }

        public IActionResult ListProperties()
        {
            return View(StaticData.propertyList);
        }

        public IActionResult DeleteProperty()
        {
            return View(StaticData.propertyList);
        }

        public IActionResult PropertyDescription(int propertyID)
        {
            PropertyModel property = StaticData.propertyList.Find(property => property.PropertyID.Equals(propertyID));
            return View(property);
        }

        public IActionResult DeleteConfirmation(int propertyID)
        {
            StaticData.propertyList.Remove(StaticData.propertyList.Find(property => property.PropertyID.Equals(propertyID)));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}