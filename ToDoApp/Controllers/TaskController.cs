namespace ToDoApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ToDoApp.Services.Data.Interfaces;
    using ToDoApp.Web.ViewModels.Task;

    public class TaskController : Controller
    {
        private readonly ITaskService taskService;
        private readonly ICategoryService categoryService;

        public TaskController(ITaskService taskService, ICategoryService categoryService)
        {
            this.taskService = taskService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var allTasks = taskService.GetAllTasks();
            return View(allTasks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            TaskFormModel model = new TaskFormModel
            {
                Categories = this.categoryService.GetAllCategories()
            };

            return Add(model);
        }

        [HttpPost]
        public IActionResult Add(TaskFormModel taskFormModel)
        {
            try
            {
                taskService.AddTask(taskFormModel);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                taskFormModel.Categories = categoryService.GetAllCategories();
                return View(taskFormModel);
            }
        }

        public IActionResult AllDoneTasks()
        {
            var allDoneTasks = taskService.AllDoneTasks();
            return View(allDoneTasks);
        }

        public IActionResult Done(int id)
        {
            taskService.DoneTask(id);
            return RedirectToAction("AllDoneTasks");
        }

        public IActionResult Details(int id)
        {
            var viewModel = taskService.Details(id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Details(TaskViewModel viewModel)
        {
            taskService.UpdateTask(viewModel.Id, viewModel);
            return RedirectToAction("Index");
        }
    }
}
