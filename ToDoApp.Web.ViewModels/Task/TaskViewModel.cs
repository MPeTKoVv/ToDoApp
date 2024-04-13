namespace ToDoApp.Web.ViewModels.Task
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }
    }
}
