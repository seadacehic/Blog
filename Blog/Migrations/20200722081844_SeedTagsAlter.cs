using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class SeedTagsAlter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application",
                columns: new[] { "CreatedAtDate", "UpdatedAtDate" },
                values: new object[] { new DateTime(2020, 7, 22, 10, 18, 44, 22, DateTimeKind.Local).AddTicks(6455), new DateTime(2020, 7, 22, 10, 18, 44, 25, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 1,
                column: "AllowedBarsList",
                value: "iOS,AR");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 2,
                column: "AllowedBarsList",
                value: "iOS,AR,Gazzda");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 3,
                column: "AllowedBarsList",
                value: "trends,innovation,2018");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "BlogSlug",
                keyValue: "augmented-reality-ios-application",
                columns: new[] { "CreatedAtDate", "UpdatedAtDate" },
                values: new object[] { new DateTime(2020, 7, 22, 10, 16, 39, 35, DateTimeKind.Local).AddTicks(3228), new DateTime(2020, 7, 22, 10, 16, 39, 41, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 1,
                column: "AllowedBarsList",
                value: "iOS, AR");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 2,
                column: "AllowedBarsList",
                value: "iOS, AR, Gazzda");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 3,
                column: "AllowedBarsList",
                value: "trends, innovation, 2018");
        }
    }
}
