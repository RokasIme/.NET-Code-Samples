using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoListWebApp.Models;
using TodoListWebApp.Services;

namespace TodoListWebApp.Controllers
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
            return RedirectToAction("ListTodo", "Home");
        }

        public IActionResult ListTodo()
        {
            var todos = _dataService.GetAllTodos();

            var todosList = new ListTodoModel()
            {
                Todos = todos
            };
            
            return View(todosList);
        }
        
        public IActionResult NewTodo()
        {
            var emptyTodoModel = new TodoModel()
            {
                Todo = "Enter Todo",
                Description = "Enter Description"
            };

            return View(emptyTodoModel);
        }

        public IActionResult CreateTodo(TodoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dataService.AddTodo(model);
                    return RedirectToAction("ListTodo");
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View("NewTodo", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
