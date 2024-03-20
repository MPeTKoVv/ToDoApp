namespace ToDoApp.Controllers
{
    using ToDoApp.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            TaskFormModel model = new TaskFormModel();

            return Add(model);
        }

        public IActionResult Add(TaskFormModel taskFormModel)
        {
            return View();
        }
    }
}
