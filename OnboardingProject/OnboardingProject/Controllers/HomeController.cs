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
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
            property.descriptions.englishDescription = "[N/A]";
            property.descriptions.italianDescription = "[N/A]";
            property.descriptions.polishDescription = "[N/A]";
            switch (StaticData.activeLanguage)
            {
                case StaticData.Language.English:
                    property.descriptions.englishDescription = property.description;
                    break;
                case StaticData.Language.Italian:
                    property.descriptions.italianDescription = property.description;
                    break;
                case StaticData.Language.Polish:
                    property.descriptions.polishDescription = property.description;
                    break;
            }
            StaticData.propertyList.Add(property);
            return RedirectToAction("ListProperties");
        }

        public IActionResult AddRoom()
        {
            return View(StaticData.propertyList);
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
                    StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).address = updated.value;
                    break;
                case 2:
                    switch (StaticData.activeLanguage)
                    {
                        case StaticData.Language.English:
                            StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).descriptions.englishDescription = updated.value;
                            break;
                        case StaticData.Language.Italian:
                            StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).descriptions.italianDescription = updated.value;
                            break;
                        case StaticData.Language.Polish:
                            StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).descriptions.polishDescription = updated.value;
                            break;
                    }
                    StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).description = updated.value;
                    break;
                case 3:
                    StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).surface = Convert.ToDouble(updated.value);
                    break;
                case 4:
                    StaticData.propertyList.Find(property => property.propertyID.Equals(updated.ID)).services = updated.value;
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
                    foreach(var item in StaticData.propertyList)
                    {
                        item.description = item.descriptions.englishDescription;
                    }
                    foreach(var item in StaticData.roomList)
                    {
                        item.description = item.descriptions.englishDescription;
                    }
                    break;
                case 1:
                    StaticData.activeLanguage = StaticData.Language.Italian;
                    foreach (var item in StaticData.propertyList)
                    {
                        item.description = item.descriptions.italianDescription;
                    }
                    foreach (var item in StaticData.roomList)
                    {
                        item.description = item.descriptions.italianDescription;
                    }
                    break;
                case 2:
                    StaticData.activeLanguage = StaticData.Language.Polish;
                    foreach (var item in StaticData.propertyList)
                    {
                        item.description = item.descriptions.polishDescription;
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
            return View(StaticData.propertyList);
        }

        public IActionResult PropertyDescription(int propertyID)
        {
            PropertyModel property = StaticData.propertyList.Find(property => property.propertyID.Equals(propertyID));

            List<RoomModel> tempRoomList = new List<RoomModel>();
            foreach (var item in StaticData.roomList)
            {
                if(item.propertyID == property.propertyID) {
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
            return View(StaticData.propertyList);
        }

        public IActionResult DeleteRoom()
        {
            return View(StaticData.propertyList);
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
                    StaticData.propertyList.Remove(StaticData.propertyList.Find(property => property.propertyID.Equals(ID)));
                    break;
                case 2:
                    StaticData.roomList.Remove(StaticData.roomList.Find(room => room.roomID.Equals(ID)));
                    break;
            }
            return View();
        }



        public IActionResult PropertyTable()
        {
            TableModel tablePackage = new TableModel(StaticData.propertyList.ToArray(), StaticData.roomList.ToArray());
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