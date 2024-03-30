using ToDoApp.Web.ViewModels.Category;

namespace ToDoApp.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<TaskSelectCategoryViewModel> GetAllCategories();
    }
}
