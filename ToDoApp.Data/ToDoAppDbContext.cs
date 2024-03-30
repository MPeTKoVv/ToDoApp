namespace ToDoApp.Data
{
    using System.Reflection;

    using Microsoft.EntityFrameworkCore;
    
    using ToDoApp.Data.Models;

    public class ToDoAppDbContext : DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
        {
        }

        public DbSet<ToDo> Tasks { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly configAssebly = Assembly.GetAssembly(typeof(ToDoAppDbContext)) ??
                                     Assembly.GetExecutingAssembly();

            modelBuilder.ApplyConfigurationsFromAssembly(configAssebly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
