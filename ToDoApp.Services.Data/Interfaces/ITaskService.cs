namespace ToDoApp.Services.Data.Interfaces
{
    using System.Xml.Serialization;
    using ToDoApp.Web.ViewModels.Task;

    public interface ITaskService
    {
        IEnumerable<TaskAllViewModel> GetAllTasks();
        IEnumerable<TaskAllViewModel> AllDoneTasks();
        void AddTask(TaskFormModel taskViewModel);
        void DoneTask(int taskId);
        TaskViewModel Details(int taskId);
        void UpdateTask(int taskId, TaskViewModel viewModel);
    }
}
