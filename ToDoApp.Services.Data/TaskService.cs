namespace ToDoApp.Services.Data
{
    using System.Threading.Tasks;
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
                Deadline = taskFormModel.Deadline
            };

            dbContext.Tasks.Add(newTask);
            dbContext.SaveChanges();
        }

        public IEnumerable<TaskViewModel> GetAllTasks()
        {
            IEnumerable<TaskViewModel> tasks = dbContext
                .Tasks
                .Select(t => new TaskViewModel
                {
                    Title = t.Title,
                    CreatedOn = t.CreatedOn,
                    Deadline = t.Deadline,
                    IsDone = t.IsDone
                })
                .Where(t => !t.IsDone)
                .OrderBy(t => t.Deadline)
                .ThenBy(t=> t.CreatedOn)
                .ToList();

            return tasks;
        }
    }
}
