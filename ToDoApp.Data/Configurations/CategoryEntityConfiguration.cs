namespace ToDoApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using ToDoApp.Data.Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories()); 
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category
            {
                Id = 1,
                Name = "Personal",
            };
            categories.Add(category);

            category = new Category
            {
                Id = 2,
                Name = "Work",
            };
            categories.Add(category);

            category = new Category
            {
                Id = 3,
                Name = "Home",
            };
            categories.Add(category);

            category = new Category
            {
                Id = 4,
                Name = "Health",
            };
            categories.Add(category);

            category = new Category
            {
                Id = 5,
                Name = "Financial",
            };
            categories.Add(category);

            category = new Category
            {
                Id = 6,
                Name = "Social",
            };
            categories.Add(category);

            category = new Category
            {
                Id = 7,
                Name = "Educational",
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
