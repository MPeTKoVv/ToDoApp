namespace ToDoApp.Web.ViewModels.Task
{
    public class TaskAllViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public DateTime? Deadline { get; set; }

        public bool IsDone { get; set; }
    }
}
