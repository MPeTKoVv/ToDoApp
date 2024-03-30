namespace ToDoApp.Services.Data
{
    using System.Collections.Generic;
    using ToDoApp.Data;
    using ToDoApp.Services.Data.Interfaces;
    using ToDoApp.Web.ViewModels.Category;

    public class CategoryService : ICategoryService
    {
        private readonly ToDoAppDbContext dbContext;
        public CategoryService(ToDoAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TaskSelectCategoryViewModel> GetAllCategories()
        {
            var categories = dbContext
                .Categories
                .Select(c => new TaskSelectCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToList();

            return categories;
        }
    }
}
