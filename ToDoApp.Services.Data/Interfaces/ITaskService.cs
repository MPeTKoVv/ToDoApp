namespace ToDoApp.Services.Data.Interfaces
{
    using ToDoApp.Web.ViewModels.Task;

    public interface ITaskService
    {
        IEnumerable<TaskViewModel> GetAllTasks();
        void AddTask(TaskFormModel taskViewModel);
    }
}
