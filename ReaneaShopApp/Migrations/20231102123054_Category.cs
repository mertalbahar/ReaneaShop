using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReaneaShopApp.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Toka" },
                    { 2, "Cüzdan" },
                    { 3, "Anahtarlık" },
                    { 4, "Çanta" },
                    { 5, "Marteniçka" },
                    { 6, "Oyuncak" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Üçgen gri toka", "Üçgen gri toka" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Üçgen pembe toka", "Üçgen pembe toka" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Üçgen turuncu toka", "Üçgen turuncu toka" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Cüzdan 1", "Cüzdan 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Cüzdan 2", "Cüzdan 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductName",
                value: "Cüzdan 3");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Pembe baykuş anahtarlık", "Pembe baykuş anahtarlık" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Sarı baykuş anahtarlık", "Sarı baykuş anahtarlık" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Yeşil baykuş anahtarlık", "Yeşil baykuş anahtarlık" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Kahverengi çiçek çanta", "Kahverengi çiçek çanta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Pembe çiçek çanta", "Pembe çiçek çanta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Mor çiçek çanta", "Mor çiçek çanta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Marteniçka dilek bilekliği", "Marteniçka dilek bilekliği" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice", "ProductSummary" },
                values: new object[] { 14, "Kuzucuk", 12m, "Kuzucuk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Çiçek", "Çiçek kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Arı", "Arı kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Kelebek", "Kelebek kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Şapka", "Şapka kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Çanta", "Çanta kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductName",
                value: "Ayakkabı");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Papatya", "Papatya kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Bal kabağı", "Bal kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Çakmak", "Çakmak kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Cüzdan", "Cüzdan kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Zambak", "Zambak kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Matruşka", "Matruşka kokulu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ProductName", "ProductSummary" },
                values: new object[] { "Tespih", "Tespih kokulu" });
        }
    }
}
