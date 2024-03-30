namespace ToDoApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ToDoApp.Data.Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category
            {
                Id = 1,
                Name = "Personal",
                ImageUrl = ""
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
