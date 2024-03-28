namespace ToDoApp.Services.Data.Interfaces
{
    using System.Xml.Serialization;
    using ToDoApp.Web.ViewModels.Task;

    public interface ITaskService
    {
        IEnumerable<TaskViewModel> GetAllTasks();
        IEnumerable<TaskViewModel> AllDoneTasks();
        void AddTask(TaskFormModel taskViewModel);
        void DoneTask(int taskId);
    }
}
