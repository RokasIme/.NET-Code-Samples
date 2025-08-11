using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoListWebApp.Models;

namespace TodoListWebApp.Controllers
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
            return RedirectToAction("ListTodo", "Home");
        }

        public IActionResult ListTodo()
        {
            
            return View();
        }
        
        public IActionResult NewTodo()
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
