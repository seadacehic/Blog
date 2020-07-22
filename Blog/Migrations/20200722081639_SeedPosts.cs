using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class SeedPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "BlogSlug", "Body", "CreatedAtDate", "Description", "TagsId", "Title", "UpdatedAtDate" },
                values: new object[] { "augmented-reality-ios-application", "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(2020, 7, 22, 10, 16, 39, 35, DateTimeKind.Local).AddTicks(3228), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", 1, "Augmented Reality iOS Application", new DateTime(2020, 7, 22, 10, 16, 39, 41, DateTimeKind.Local).AddTicks(2130) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application");
        }
    }
}
