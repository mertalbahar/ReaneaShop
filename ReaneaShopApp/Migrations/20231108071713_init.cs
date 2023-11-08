using System;
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
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    District = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    Avenue = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Shipped = table.Column<bool>(type: "INTEGER", nullable: false),
                    OrderedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
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
                    ProductImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    Showcase = table.Column<bool>(type: "INTEGER", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CartLine",
                columns: table => new
                {
                    CartLineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLine", x => x.CartLineId);
                    table.ForeignKey(
                        name: "FK_CartLine_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_CartLine_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "ProductId", "CategoryId", "ProductImageUrl", "ProductName", "ProductPrice", "ProductSummary", "Showcase" },
                values: new object[,]
                {
                    { 1, 1, "/images/toka.jpg", "Üçgen gri toka", 250m, "Üçgen gri toka", true },
                    { 2, 1, "/images/toka.jpg", "Üçgen pembe toka", 1300m, "Üçgen pembe toka", false },
                    { 3, 1, "/images/toka.jpg", "Üçgen turuncu toka", 250m, "Üçgen turuncu toka", false },
                    { 4, 2, "/images/cuzdan.jpg", "Cüzdan 1", 37m, "Cüzdan 1", true },
                    { 5, 2, "/images/cuzdan.jpg", "Cüzdan 2", 3865m, "Cüzdan 2", false },
                    { 6, 2, "/images/cuzdan.jpg", "Cüzdan 3", 805m, "Cüzdan 3", false },
                    { 7, 3, "/images/baykusanahtar.jpg", "Pembe baykuş anahtarlık", 120m, "Pembe baykuş anahtarlık", true },
                    { 8, 3, "/images/baykusanahtar.jpg", "Sarı baykuş anahtarlık", 11280m, "Sarı baykuş anahtarlık", false },
                    { 9, 3, "/images/baykusanahtar.jpg", "Yeşil baykuş anahtarlık", 85m, "Yeşil baykuş anahtarlık", false },
                    { 10, 4, "/images/kahvecanta.jpg", "Kahverengi çiçek çanta", 420m, "Kahverengi çiçek çanta", true },
                    { 11, 4, "/images/pembecanta.jpg", "Pembe çiçek çanta", 120m, "Pembe çiçek çanta", false },
                    { 12, 4, "/images/kahvecanta.jpg", "Mor çiçek çanta", 375m, "Mor çiçek çanta", false },
                    { 13, 5, "/images/martenicka.jpg", "Marteniçka dilek bilekliği", 12m, "Marteniçka dilek bilekliği", true },
                    { 14, 6, "/images/kuzucuk.jpg", "Kuzucuk", 12m, "Kuzucuk", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_OrderId",
                table: "CartLine",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_ProductId",
                table: "CartLine",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLine");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
