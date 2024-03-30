using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://thenounproject.com/icon/personal-task-396627/", "Personal" },
                    { 2, "https://thenounproject.com/icon/job-4080118/", "Work" },
                    { 3, "https://thenounproject.com/icon/task-home-2676056/", "Home" },
                    { 4, "https://thenounproject.com/icon/clipboard-3990469/", "Personal" },
                    { 5, "https://thenounproject.com/icon/financial-report-5974043/", "Financial" },
                    { 6, "https://thenounproject.com/icon/share-task-396661/", "Social" },
                    { 7, "https://thenounproject.com/icon/assignment-4027357/", "Educational" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
