namespace ToDoApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ToDoApp.Services.Data.Interfaces;
    using ToDoApp.Web.ViewModels.Task;

    public class TaskController : Controller
    {
        private readonly ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

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

        [HttpPost]
        public IActionResult Add(TaskFormModel taskFormModel)
        {
            if (taskFormModel.Deadline < DateTime.UtcNow)
            {

            }

            try
            {
            taskService.AddTask(taskFormModel);
                return RedirectToAction("Index", "Home");

            }
            catch (Exception)
            {

                return View(taskFormModel);
            }
        }

        public IActionResult AllDoneTasks()
        {
            var allDoneTasks = taskService.AllDoneTasks();
            return View(allDoneTasks);
        }
    }
}
