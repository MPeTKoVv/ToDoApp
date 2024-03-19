namespace ToDoApp.Data
{
    using ToDoApp.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ToDoAppDbContext : DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
        {
        }

        public DbSet<ToDo> Tasks { get; set; } = null!;
    }
}
