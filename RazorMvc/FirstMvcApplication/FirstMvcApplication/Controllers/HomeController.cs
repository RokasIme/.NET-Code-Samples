using FirstMvcApplication.Models;
using FirstMvcApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace FirstMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataService _dataService;

        public HomeController(ILogger<HomeController> logger, DataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            // C# backend logic is here
            return View();
        }

        public IActionResult AboutMe()
        {
            var personModel = new PersonModel()
            {
                Name = "Rokas Imelinskas"
            };

            return View(personModel);
        }

        // Display page with the form
        public IActionResult DisplaySubmitData()
        {
            var emptyModel = new PersonModel()
            {
                Name = "Enter your name"
            };
            return View(emptyModel);
        }

        //will receive filled model and will save to file
        public IActionResult SendSubmitData(PersonModel model)
        {
            //System.IO.File.WriteAllText("test.txt", model.Name);    áraðo duomenis á failà
            _dataService.Add(model);
            return RedirectToAction("DisplaySubmitData");
        }

        public IActionResult NamesList()         {
            // Get all persons from the data service
            var persons = _dataService.GetAll();

            var personList = new NamesListModel()
            {
                Persons = persons
            };
            return View(personList);
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
