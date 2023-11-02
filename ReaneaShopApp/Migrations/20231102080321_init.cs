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
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    ProductSummary = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

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
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
