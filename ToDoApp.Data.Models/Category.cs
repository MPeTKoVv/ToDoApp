using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Tasks = new HashSet<ToDo>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        public virtual ICollection<ToDo> Tasks { get; set; } = null!;
    }
}
