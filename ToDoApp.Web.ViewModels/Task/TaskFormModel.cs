namespace ToDoApp.Web.ViewModels.Task
{
    using System.ComponentModel.DataAnnotations;

    using ToDoApp.Web.ViewModels.Category;
    using static ToDoApp.Common.DataValidationConstants.ToDo;

    public class TaskFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public DateTime? Deadline { get; set; }

        public IEnumerable<TaskSelectCategoryViewModel> Categories { get; set; }

    }
}
