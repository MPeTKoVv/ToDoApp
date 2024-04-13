namespace ToDoApp.Services.Data
{
    using ToDoApp.Data;
    using ToDoApp.Data.Models;
    using ToDoApp.Services.Data.Interfaces;
    using ToDoApp.Web.ViewModels.Task;

    public class TaskService : ITaskService
    {
        private readonly ToDoAppDbContext dbContext;

        public TaskService(ToDoAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddTask(TaskFormModel taskFormModel)
        {
            var newTask = new ToDo
            {
                Title = taskFormModel.Title,
                Description = taskFormModel.Description,
                Priority = taskFormModel.Priority,
                CategoryId = taskFormModel.CategoryId
            };

            dbContext.Tasks.Add(newTask);
            dbContext.SaveChanges();
        }

        public IEnumerable<TaskAllViewModel> AllDoneTasks()
        {
            IEnumerable<TaskAllViewModel> tasks = dbContext
                .Tasks
                .Select(t => new TaskAllViewModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    CreatedOn = t.CreatedOn,
                    Priority = t.Priority,
                    IsDone = t.IsDone,
                })
                .Where(t => t.IsDone)
                .OrderBy(t => t.CreatedOn)
                .ToList();

            return tasks;
        }

        public TaskViewModel Details(int taskId)
        {
            var task = dbContext.
                Tasks.
                FirstOrDefault(t => t.Id == taskId);

            var taskViewModel = new TaskViewModel
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                CreatedOn = task.CreatedOn,
                Priority = task.Priority,
                IsDone = task.IsDone
            };

            return taskViewModel;
        }

        public void DoneTask(int taskId)
        {
            var task = dbContext
                .Tasks
                .FirstOrDefault(t => t.Id == taskId);

            task.IsDone = true;

            dbContext.SaveChanges();
        }

        public IEnumerable<TaskAllViewModel> GetAllTasks()
        {
            IEnumerable<TaskAllViewModel> tasks = dbContext
                .Tasks
                .Select(t => new TaskAllViewModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    CreatedOn = t.CreatedOn,
                    Priority = t.Priority,
                    IsDone = t.IsDone
                })
                .Where(t => !t.IsDone)
                .OrderBy(t => t.CreatedOn)
                .ToList();

            return tasks;
        }

        public void UpdateTask(int taskId, TaskViewModel viewModel)
        {
            var task = dbContext
                .Tasks
                .FirstOrDefault(t => t.Id == taskId);

            task.Title = viewModel.Title;
            task.Description = viewModel.Description;
            task.Priority = viewModel.Priority;

            dbContext.SaveChanges();
        }
    }
}
