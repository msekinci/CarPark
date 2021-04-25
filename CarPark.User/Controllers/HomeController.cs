using CarPark.Entities.Concrete;
using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly MongoClient client;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
            client = new MongoClient("mongodb+srv://msekinci:serkanE.5179@carparkcluster.vivp8.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        }

        public IActionResult Index()
        {
            var database = client.GetDatabase("CarParkDB");

            var jsonString = System.IO.File.ReadAllText("cities.json");
            var citiesModel = JsonConvert.DeserializeObject<List<cities>>(jsonString);
            var citiesCollection = database.GetCollection<City>("City");

            foreach (var item in citiesModel)
            {
                var city = new City()
                {
                    Id = ObjectId.GenerateNewId(),
                    Name = item.name,
                    Plate = item.plate,
                    Latitude = item.latitude,
                    Longitude = item.longitude,
                    Counties = new List<County>()
                };

                foreach (var c in item.counties)
                {
                    city.Counties.Add(new County
                    {
                        Id = ObjectId.GenerateNewId(),
                        Name = c,
                        Latitude = "",
                        Longitude = ""
                    });
                }
                citiesCollection.InsertOne(city);
            }

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
