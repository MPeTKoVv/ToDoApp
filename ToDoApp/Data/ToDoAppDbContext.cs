using Microsoft.EntityFrameworkCore;
using ToDoApp.Data.DataModels;

namespace ToDoApp.Data
{
    public class ToDoAppDbContext : DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
        {
        }

        public DbSet<ToDo> Tasks { get; set; } = null!;
    }
}
