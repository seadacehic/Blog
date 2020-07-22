using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class SeedPostsgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application",
                columns: new[] { "CreatedAtDate", "UpdatedAtDate" },
                values: new object[] { new DateTime(2020, 7, 22, 11, 2, 41, 404, DateTimeKind.Local).AddTicks(5545), new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "BlogSlug", "Body", "CreatedAtDate", "Description", "TagsId", "Title", "UpdatedAtDate" },
                values: new object[,]
                {
                    { "trends-slug", "An opinionated commentary, of the most important presentation of the year", new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(5210), "Ever wonder how?", 3, "Internet Trends 2018", new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(5239) },
                    { "augmented-reality-ios-application-2", "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(5259), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", 2, "Augmented Reality iOS Application 2", new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(5264) },
                    { "augmented-reality-ios-application-3", "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(5273), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", 1, "Augmented Reality iOS Application 3", new DateTime(2020, 7, 22, 11, 2, 41, 409, DateTimeKind.Local).AddTicks(5278) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application-2");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application-3");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "trends-slug");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application",
                columns: new[] { "CreatedAtDate", "UpdatedAtDate" },
                values: new object[] { new DateTime(2020, 7, 22, 10, 18, 44, 22, DateTimeKind.Local).AddTicks(6455), new DateTime(2020, 7, 22, 10, 18, 44, 25, DateTimeKind.Local).AddTicks(7679) });
        }
    }
}
