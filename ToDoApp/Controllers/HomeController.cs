namespace ToDoApp.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    
    using ToDoApp.Web.ViewModels.Home;
    using ToDoApp.Services.Data.Interfaces;


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
