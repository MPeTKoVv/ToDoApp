namespace ToDoApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static ToDoApp.Common.DataValidationConstants.ToDo;

    public class ToDo
    {
        public ToDo()
        {
            CreatedOn = DateTime.Now;
            IsDone = false;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime? Deadline { get; set; }

        public bool IsDone { get; set; }
    }
}
