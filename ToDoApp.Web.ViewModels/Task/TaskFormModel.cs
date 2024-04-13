namespace ToDoApp.Web.ViewModels.Task
{
    using System.ComponentModel.DataAnnotations;

    using ToDoApp.Web.ViewModels.Category;
    using static ToDoApp.Common.DataValidationConstants.ToDo;

    public class TaskFormModel
    {
        public TaskFormModel()
        {
            this.Categories = new HashSet<TaskSelectCategoryViewModel>();
        }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public int Priority { get; set; }

        public IEnumerable<TaskSelectCategoryViewModel> Categories { get; set; } = null!;

    }
}
