using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnboardingProject;
using OnboardingProject.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OnboardingProject.Controllers
{

    public class HomeController : Controller
    {
        private readonly PropertyDBContext propertyDBContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(PropertyDBContext propertyDBContext, ILogger<HomeController> logger)
        {
            this.propertyDBContext = propertyDBContext;
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
        public IActionResult AddPropertyMethod([FromForm] PropertyDataModel property)
        {
            property.EnglishDescription = "[N/A]";
            property.ItalianDescription = "[N/A]";
            property.PolishDescription = "[N/A]";
            switch (StaticData.activeLanguage)
            {
                case StaticData.Language.English:
                    property.EnglishDescription = property.Description;
                    break;
                case StaticData.Language.Italian:
                    property.ItalianDescription = property.Description;
                    break;
                case StaticData.Language.Polish:
                    property.PolishDescription = property.Description;
                    break;
            }
            propertyDBContext.Property.Add(property);
            propertyDBContext.SaveChanges();
            return RedirectToAction("ListProperties");
        }

        public IActionResult AddRoom()
        {
            return View(propertyDBContext.Property.ToList());
        }

        public IActionResult AddRoomSurvey(int propertyID)
        {
            StaticData.propertyAddedTo = propertyID;
            return View();
        }

        [HttpPost]
        public IActionResult AddRoomSurveyMethod([FromForm] RoomDataModel room)
        {
            room.EnglishDescription = "[N/A]";
            room.ItalianDescription = "[N/A]";
            room.PolishDescription = "[N/A]";
            room.PropertyId = StaticData.propertyAddedTo;
            switch (StaticData.activeLanguage)
            {
                case StaticData.Language.English:
                    room.EnglishDescription = room.Description;
                    break;
                case StaticData.Language.Italian:
                    room.ItalianDescription = room.Description;
                    break;
                case StaticData.Language.Polish:
                    room.PolishDescription = room.Description;
                    break;
            }
            propertyDBContext.Room.Add(room);
            propertyDBContext.SaveChanges();
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
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Address = updated.value;
                    break;
                case 2:
                    switch (StaticData.activeLanguage)
                    {
                        case StaticData.Language.English:
                            propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).EnglishDescription = updated.value;
                            break;
                        case StaticData.Language.Italian:
                            propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).ItalianDescription = updated.value;
                            break;
                        case StaticData.Language.Polish:
                            propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).PolishDescription = updated.value;
                            break;
                    }
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Description = updated.value;
                    break;
                case 3:
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Surface = Convert.ToDouble(updated.value);
                    break;
                case 4:
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Services = updated.value;
                    break;
            }
            propertyDBContext.Update(propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID));
            propertyDBContext.SaveChanges();
            return RedirectToAction("ListProperties");
        }

        public IActionResult UpdateRoom(int roomID, int index)
        {
            UpdateModel sendPackage = new UpdateModel(roomID, index);
            return View(sendPackage);
        }

        [HttpPost]
        public IActionResult UpdateRoomMethod([FromForm] UpdateModel updated)
        {

            switch (updated.index)
            {
                case 1:
                    switch (StaticData.activeLanguage)
                    {
                        case StaticData.Language.English:
                            propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID).EnglishDescription = updated.value;
                            break;
                        case StaticData.Language.Italian:
                            propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID).ItalianDescription = updated.value;
                            break;
                        case StaticData.Language.Polish:
                            propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID).PolishDescription = updated.value;
                            break;
                    }
                    propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID).Description = updated.value;
                    break;
                case 2:
                    propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID).Beds = Convert.ToInt32(updated.value);
                    break;
                case 3:
                    propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID).Surface = Convert.ToDouble(updated.value);
                    break;
            }
            propertyDBContext.Update(propertyDBContext.Room.FirstOrDefault(x => x.Id == updated.ID));
            propertyDBContext.SaveChanges();
            return RedirectToAction("ListProperties");
        }

        public IActionResult ChangeLanguageMethod(int language)
        {
            switch (language)
            {
                case 0:
                    StaticData.activeLanguage = StaticData.Language.English;
                    foreach(var item in propertyDBContext.Property)
                    {
                        item.Description = item.EnglishDescription;
                        propertyDBContext.Update(item); 
                    }
                    foreach(var item in propertyDBContext.Room)
                    {
                        item.Description = item.EnglishDescription;
                        propertyDBContext.Update(item);
                    }
                    break;
                case 1:
                    StaticData.activeLanguage = StaticData.Language.Italian;
                    foreach (var item in propertyDBContext.Property)
                    {
                        item.Description = item.ItalianDescription;
                        propertyDBContext.Update(item);
                    }
                    foreach (var item in propertyDBContext.Room)
                    {
                        item.Description = item.ItalianDescription;
                        propertyDBContext.Update(item);
                    }
                    break;
                case 2:
                    StaticData.activeLanguage = StaticData.Language.Polish;
                    foreach (var item in propertyDBContext.Property)
                    {
                        item.Description = item.PolishDescription;
                        propertyDBContext.Update(item);
                    }
                    foreach (var item in propertyDBContext.Room)
                    {
                        item.Description = item.PolishDescription;
                        propertyDBContext.Update(item);
                    }
                    break;
            }
            propertyDBContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ListProperties()
        {
            return View(propertyDBContext.Property.ToList());
        }

        public IActionResult PropertyDescription(int propertyID)
        {
            PropertyDataModel property = propertyDBContext.Property.FirstOrDefault(x => x.Id == propertyID);

            List<RoomDataModel> tempRoomList = new List<RoomDataModel>();
            foreach (var item in propertyDBContext.Room)
            {
                if(item.PropertyId == property.Id) {
                    tempRoomList.Add(item);
                }
            }
            RoomDataModel[] rooms = tempRoomList.ToArray();

            PropertyDescriptionModel descriptionPackage = new PropertyDescriptionModel(property, rooms);

            return View(descriptionPackage);
        }

        public IActionResult RoomDescription(int roomID)
        {
            RoomDataModel room = propertyDBContext.Room.FirstOrDefault(x => x.Id == roomID);
            return View(room);
        }

        public IActionResult DeleteProperty()
        {
            return View(propertyDBContext.Property.ToList());
        }

        public IActionResult DeleteRoom()
        {
            return View(propertyDBContext.Property.ToList());
        }

        public IActionResult DeleteRoomList(int propertyID)
        {
            List<RoomDataModel> tempRoomList = new List<RoomDataModel>();
            foreach (var item in propertyDBContext.Room)
            {
                if (item.PropertyId == propertyID)
                {
                    tempRoomList.Add(item);
                }
            }
            return View(tempRoomList);
        }

        public IActionResult DeleteConfirmation(int ID, int index)
        {
            switch (index)
            {
                case 1:
                    propertyDBContext.Property.Remove(propertyDBContext.Property.FirstOrDefault(x => x.Id == ID));
                    propertyDBContext.Update(propertyDBContext.Property.FirstOrDefault(x => x.Id == ID));
                    break;
                case 2:
                    propertyDBContext.Room.Remove(propertyDBContext.Room.FirstOrDefault(x => x.Id == ID));
                    propertyDBContext.Update(propertyDBContext.Room.FirstOrDefault(x => x.Id == ID));
                    break;
            }
            propertyDBContext.SaveChanges();
            return View();
        }



        public IActionResult PropertyTable()
        {
            TableModel tablePackage = new TableModel(propertyDBContext.Property.ToArray(), propertyDBContext.Room.ToArray());
            return View(tablePackage);
        }



        public IActionResult WeatherPage(OpenWeatherMap openWeatherMap)
        {
            openWeatherMap = new OpenWeatherMap();

            // Calling API http://openweathermap.org/api

            string apiKey = "ce9b3d4f0ac2ad292fa4277f74e1c29e";
            string city = "Palermo";
            HttpWebRequest apiRequest =
            WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" +
            city + "&appid=" + apiKey + "&units=metric") as HttpWebRequest;

            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }

            ResponseWeather rootObject = JsonConvert.DeserializeObject<ResponseWeather>(apiResponse);

            List<string> sb = new List<string>();
            sb.Add(rootObject.name);
            sb.Add(rootObject.sys.country);
            sb.Add(rootObject.wind.speed.ToString());
            sb.Add(rootObject.main.temp.ToString());
            sb.Add(rootObject.main.humidity.ToString());
            sb.Add(rootObject.weather[0].description);

            openWeatherMap.apiResponse = sb.ToArray();

            return View(openWeatherMap);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}