using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class SeedTags2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagsId", "AllowedBarsList" },
                values: new object[] { 2, "iOS, AR, Gazzda" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagsId", "AllowedBarsList" },
                values: new object[] { 3, "trends, innovation, 2018" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagsId",
                keyValue: 3);
        }
    }
}
