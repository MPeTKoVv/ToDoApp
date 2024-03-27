namespace ToDoApp.Web.ViewModels.Task
{
    using System.ComponentModel.DataAnnotations;

    using static ToDoApp.Common.DataValidationConstants.ToDo;

    public class TaskFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        
        public DateTime? Deadline { get; set; }
    }
}
