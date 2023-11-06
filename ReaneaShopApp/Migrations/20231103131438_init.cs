using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReaneaShopApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductSummary = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductName", "ProductPrice", "ProductSummary" },
                values: new object[,]
                {
                    { 1, 1, "Üçgen gri toka", 250m, "Üçgen gri toka" },
                    { 2, 1, "Üçgen pembe toka", 1300m, "Üçgen pembe toka" },
                    { 3, 1, "Üçgen turuncu toka", 250m, "Üçgen turuncu toka" },
                    { 4, 2, "Cüzdan 1", 37m, "Cüzdan 1" },
                    { 5, 2, "Cüzdan 2", 3865m, "Cüzdan 2" },
                    { 6, 2, "Cüzdan 3", 805m, "Cüzdan 3" },
                    { 7, 3, "Pembe baykuş anahtarlık", 120m, "Pembe baykuş anahtarlık" },
                    { 8, 3, "Sarı baykuş anahtarlık", 11280m, "Sarı baykuş anahtarlık" },
                    { 9, 3, "Yeşil baykuş anahtarlık", 85m, "Yeşil baykuş anahtarlık" },
                    { 10, 4, "Kahverengi çiçek çanta", 420m, "Kahverengi çiçek çanta" },
                    { 11, 4, "Pembe çiçek çanta", 120m, "Pembe çiçek çanta" },
                    { 12, 4, "Mor çiçek çanta", 375m, "Mor çiçek çanta" },
                    { 13, 5, "Marteniçka dilek bilekliği", 12m, "Marteniçka dilek bilekliği" },
                    { 14, 6, "Kuzucuk", 12m, "Kuzucuk" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
