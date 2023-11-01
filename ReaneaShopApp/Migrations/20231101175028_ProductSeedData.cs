using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReaneaShopApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductSummary" },
                values: new object[,]
                {
                    { 1, "Çiçek", 250m, "Çiçek kokulu" },
                    { 2, "Arı", 1300m, "Arı kokulu" },
                    { 3, "Kelebek", 250m, "Kelebek kokulu" },
                    { 4, "Şapka", 37m, "Şapka kokulu" },
                    { 5, "Çanta", 3865m, "Çanta kokulu" },
                    { 6, "Ayakkabı", 805m, "Ayakkabı kokulu" },
                    { 7, "Papatya", 120m, "Papatya kokulu" },
                    { 8, "Bal kabağı", 11280m, "Bal kokulu" },
                    { 9, "Çakmak", 85m, "Çakmak kokulu" },
                    { 10, "Cüzdan", 420m, "Cüzdan kokulu" },
                    { 11, "Zambak", 120m, "Zambak kokulu" },
                    { 12, "Matruşka", 375m, "Matruşka kokulu" },
                    { 13, "Tespih", 12m, "Tespih kokulu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);
        }
    }
}
