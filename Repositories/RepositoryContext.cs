using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, ProductName = "Üçgen gri toka", ProductSummary = "Üçgen gri toka", ProductPrice = 250 },
                new Product() { ProductId = 2, ProductName = "Üçgen pembe toka", ProductSummary = "Üçgen pembe toka", ProductPrice = 1_300 },
                new Product() { ProductId = 3, ProductName = "Üçgen turuncu toka", ProductSummary = "Üçgen turuncu toka", ProductPrice = 250 },
                new Product() { ProductId = 4, ProductName = "Cüzdan 1", ProductSummary = "Cüzdan 1", ProductPrice = 37 },
                new Product() { ProductId = 5, ProductName = "Cüzdan 2", ProductSummary = "Cüzdan 2", ProductPrice = 3_865 },
                new Product() { ProductId = 6, ProductName = "Cüzdan 3", ProductSummary = "Cüzdan 3", ProductPrice = 805 },
                new Product() { ProductId = 7, ProductName = "Pembe baykuş anahtarlık", ProductSummary = "Pembe baykuş anahtarlık", ProductPrice = 120 },
                new Product() { ProductId = 8, ProductName = "Sarı baykuş anahtarlık", ProductSummary = "Sarı baykuş anahtarlık", ProductPrice = 11_280 },
                new Product() { ProductId = 9, ProductName = "Yeşil baykuş anahtarlık", ProductSummary = "Yeşil baykuş anahtarlık", ProductPrice = 85 },
                new Product() { ProductId = 10, ProductName = "Kahverengi çiçek çanta", ProductSummary = "Kahverengi çiçek çanta", ProductPrice = 420 },
                new Product() { ProductId = 11, ProductName = "Pembe çiçek çanta", ProductSummary = "Pembe çiçek çanta", ProductPrice = 120 },
                new Product() { ProductId = 12, ProductName = "Mor çiçek çanta", ProductSummary = "Mor çiçek çanta", ProductPrice = 375 },
                new Product() { ProductId = 13, ProductName = "Marteniçka dilek bilekliği", ProductSummary = "Marteniçka dilek bilekliği", ProductPrice = 12 },
                new Product() { ProductId = 14, ProductName = "Kuzucuk", ProductSummary = "Kuzucuk", ProductPrice = 12 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() {CategoryId=1, CategoryName="Toka"},
                new Category() {CategoryId=2, CategoryName="Cüzdan"},
                new Category() {CategoryId=3, CategoryName="Anahtarlık"},
                new Category() {CategoryId=4, CategoryName="Çanta"},
                new Category() {CategoryId=5, CategoryName="Marteniçka"},
                new Category() {CategoryId=6, CategoryName="Oyuncak"}
            );
        }
    }
}