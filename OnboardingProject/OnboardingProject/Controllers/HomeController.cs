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
        public IActionResult AddRoomSurveyMethod([FromForm] RoomModel room)
        {
            room.descriptions.englishDescription = "[N/A]";
            room.descriptions.italianDescription = "[N/A]";
            room.descriptions.polishDescription = "[N/A]";
            room.propertyID = StaticData.propertyAddedTo;
            switch (StaticData.activeLanguage)
            {
                case StaticData.Language.English:
                    room.descriptions.englishDescription = room.description;
                    break;
                case StaticData.Language.Italian:
                    room.descriptions.italianDescription = room.description;
                    break;
                case StaticData.Language.Polish:
                    room.descriptions.polishDescription = room.description;
                    break;
            }
            StaticData.roomList.Add(room);
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
                    propertyDBContext.SaveChanges();
                    break;
                case 2:
                    switch (StaticData.activeLanguage)
                    {
                        case StaticData.Language.English:
                            propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).EnglishDescription = updated.value;
                            propertyDBContext.SaveChanges();
                            break;
                        case StaticData.Language.Italian:
                            propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).ItalianDescription = updated.value;
                            propertyDBContext.SaveChanges();
                            break;
                        case StaticData.Language.Polish:
                            propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).PolishDescription = updated.value;
                            propertyDBContext.SaveChanges();
                            break;
                    }
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Description = updated.value;
                    propertyDBContext.SaveChanges();
                    break;
                case 3:
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Surface = Convert.ToDouble(updated.value);
                    propertyDBContext.SaveChanges();
                    break;
                case 4:
                    propertyDBContext.Property.FirstOrDefault(x => x.Id == updated.ID).Services = updated.value;
                    propertyDBContext.SaveChanges();
                    break;
            }
            
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
                            StaticData.roomList.Find(room => room.roomID.Equals(updated.ID)).descriptions.englishDescription = updated.value;
                            break;
                        case StaticData.Language.Italian:
                            StaticData.roomList.Find(room => room.roomID.Equals(updated.ID)).descriptions.italianDescription = updated.value;
                            break;
                        case StaticData.Language.Polish:
                            StaticData.roomList.Find(room => room.roomID.Equals(updated.ID)).descriptions.polishDescription = updated.value;
                            break;
                    }
                    StaticData.roomList.Find(room => room.roomID.Equals(updated.ID)).description = updated.value;
                    break;
                case 2:
                    StaticData.roomList.Find(room => room.roomID.Equals(updated.ID)).beds = Convert.ToInt32(updated.value);
                    break;
                case 3:
                    StaticData.roomList.Find(room => room.roomID.Equals(updated.ID)).surface = Convert.ToDouble(updated.value);
                    break;
            }
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
                        propertyDBContext.SaveChanges();
                    }
                    foreach(var item in StaticData.roomList)
                    {
                        item.description = item.descriptions.englishDescription;
                    }
                    break;
                case 1:
                    StaticData.activeLanguage = StaticData.Language.Italian;
                    foreach (var item in propertyDBContext.Property)
                    {
                        item.Description = item.ItalianDescription;
                        propertyDBContext.SaveChanges();
                    }
                    foreach (var item in StaticData.roomList)
                    {
                        item.description = item.descriptions.italianDescription;
                    }
                    break;
                case 2:
                    StaticData.activeLanguage = StaticData.Language.Polish;
                    foreach (var item in propertyDBContext.Property)
                    {
                        item.Description = item.PolishDescription;
                        propertyDBContext.SaveChanges();
                    }
                    foreach (var item in StaticData.roomList)
                    {
                        item.description = item.descriptions.polishDescription;
                    }
                    break;
            }
            return RedirectToAction("Index");
        }

        public IActionResult ListProperties()
        {
            return View(propertyDBContext.Property.ToList());
        }

        public IActionResult PropertyDescription(int propertyID)
        {
            PropertyDataModel property = propertyDBContext.Property.FirstOrDefault(x => x.Id == propertyID);

            List<RoomModel> tempRoomList = new List<RoomModel>();
            foreach (var item in StaticData.roomList)
            {
                if(item.propertyID == property.Id) {
                    tempRoomList.Add(item);
                }
            }
            RoomModel[] rooms = tempRoomList.ToArray();

            PropertyDescriptionModel descriptionPackage = new PropertyDescriptionModel(property, rooms);

            return View(descriptionPackage);
        }

        public IActionResult RoomDescription(int roomID)
        {
            RoomModel room = StaticData.roomList.Find(room => room.roomID.Equals(roomID));
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
            List<RoomModel> tempRoomList = new List<RoomModel>();
            foreach (var item in StaticData.roomList)
            {
                if (item.propertyID == propertyID)
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
                    propertyDBContext.SaveChanges();
                    break;
                case 2:
                    StaticData.roomList.Remove(StaticData.roomList.Find(room => room.roomID.Equals(ID)));
                    break;
            }
            return View();
        }



        public IActionResult PropertyTable()
        {
            TableModel tablePackage = new TableModel(propertyDBContext.Property.ToArray(), StaticData.roomList.ToArray());
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