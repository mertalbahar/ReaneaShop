using Microsoft.EntityFrameworkCore;

namespace ReaneaShopApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, ProductName = "Çiçek", ProductSummary = "Çiçek kokulu", ProductPrice = 250 },
                new Product() { ProductId = 2, ProductName = "Arı", ProductSummary = "Arı kokulu", ProductPrice = 1_300 },
                new Product() { ProductId = 3, ProductName = "Kelebek", ProductSummary = "Kelebek kokulu", ProductPrice = 250 },
                new Product() { ProductId = 4, ProductName = "Şapka", ProductSummary = "Şapka kokulu", ProductPrice = 37 },
                new Product() { ProductId = 5, ProductName = "Çanta", ProductSummary = "Çanta kokulu", ProductPrice = 3_865 },
                new Product() { ProductId = 6, ProductName = "Ayakkabı", ProductSummary = "Ayakkabı kokulu", ProductPrice = 805 },
                new Product() { ProductId = 7, ProductName = "Papatya", ProductSummary = "Papatya kokulu", ProductPrice = 120 },
                new Product() { ProductId = 8, ProductName = "Bal kabağı", ProductSummary = "Bal kokulu", ProductPrice = 11_280 },
                new Product() { ProductId = 9, ProductName = "Çakmak", ProductSummary = "Çakmak kokulu", ProductPrice = 85 },
                new Product() { ProductId = 10, ProductName = "Cüzdan", ProductSummary = "Cüzdan kokulu", ProductPrice = 420 },
                new Product() { ProductId = 11, ProductName = "Zambak", ProductSummary = "Zambak kokulu", ProductPrice = 120 },
                new Product() { ProductId = 12, ProductName = "Matruşka", ProductSummary = "Matruşka kokulu", ProductPrice = 375 },
                new Product() { ProductId = 13, ProductName = "Tespih", ProductSummary = "Tespih kokulu", ProductPrice = 12 }
            );
        }
    }
}