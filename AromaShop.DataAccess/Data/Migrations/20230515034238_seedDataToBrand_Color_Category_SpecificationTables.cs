using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AromaShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataToBrand_Color_Category_SpecificationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "ImagePath", "Name", "Summary" },
                values: new object[,]
                {
                    { 1, null, "Apple", null },
                    { 2, null, "Asus", null },
                    { 3, null, "Gionee", null },
                    { 4, null, "Micromax", null },
                    { 5, null, "Samsung", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImagePath", "Name", "Summary" },
                values: new object[,]
                {
                    { 1, "/img/home/hero-slide1.png", "Men", "Men item" },
                    { 2, "/img/home/hero-slide3.png", "Women", "Women item" },
                    { 3, "/img/home/hero-slide2.png", "Accessories", "Accessories item" },
                    { 4, "/img/home/hero-slide1.png", "Footwear", "Footwear item" },
                    { 5, "/img/home/hero-slide2.png", "Bay item", "Bay item" },
                    { 6, "/img/home/hero-slide3.png", "Electronics", "Electronics item" },
                    { 7, "/img/home/hero-slide2.png", "Food", "Food item" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, "black", null, "Black" },
                    { 2, "black leather", null, "Black Leather" },
                    { 3, "black with red", null, "Black with red" },
                    { 4, "gold", null, "Gold" },
                    { 5, "spacegrey", null, "Spacegrey" }
                });

            migrationBuilder.InsertData(
                table: "Specification",
                columns: new[] { "Id", "Name", "Summary" },
                values: new object[,]
                {
                    { 1, "Width", null },
                    { 2, "Height", null },
                    { 3, "Depth", null },
                    { 4, "Quality checking", null },
                    { 5, "Freshness Duration", null },
                    { 6, "When packeting", null },
                    { 7, "Each Box contains", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specification",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
