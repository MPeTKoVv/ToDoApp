namespace ToDoApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ToDoApp.Web.ViewModels.Task;

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
