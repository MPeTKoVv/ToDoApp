namespace ToDoApp.Web.Controllers
{
    using System.Diagnostics;
    
    using ToDoApp.Web.ViewModels;
    using ToDoApp.Services.Data.Interfaces;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private ITaskService taskService;

        public HomeController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        public IActionResult Index()
        {
            var allTasks = taskService.GetAllTasks();
            return View(allTasks);
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
