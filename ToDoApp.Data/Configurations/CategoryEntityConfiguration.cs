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
                ImageUrl = "https://thenounproject.com/icon/personal-task-396627/"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 2,
                Name = "Work",
                ImageUrl = "https://thenounproject.com/icon/job-4080118/"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 3,
                Name = "Home",
                ImageUrl = "https://thenounproject.com/icon/task-home-2676056/"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 4,
                Name = "Personal",
                ImageUrl = "https://thenounproject.com/icon/clipboard-3990469/"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 5,
                Name = "Financial",
                ImageUrl = "https://thenounproject.com/icon/financial-report-5974043/"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 6,
                Name = "Social",
                ImageUrl = "https://thenounproject.com/icon/share-task-396661/"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 7,
                Name = "Educational",
                ImageUrl = "https://thenounproject.com/icon/assignment-4027357/"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
