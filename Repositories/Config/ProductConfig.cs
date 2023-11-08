using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ProductPrice).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 1, ProductImageUrl = "/images/toka.jpg", ProductName = "Üçgen gri toka", ProductSummary = "Üçgen gri toka", Showcase = true, ProductPrice = 250 },
                new Product() { ProductId = 2, CategoryId = 1, ProductImageUrl = "/images/toka.jpg", ProductName = "Üçgen pembe toka", ProductSummary = "Üçgen pembe toka", Showcase = false, ProductPrice = 1_300 },
                new Product() { ProductId = 3, CategoryId = 1, ProductImageUrl = "/images/toka.jpg", ProductName = "Üçgen turuncu toka", ProductSummary = "Üçgen turuncu toka", Showcase = false, ProductPrice = 250 },
                new Product() { ProductId = 4, CategoryId = 2, ProductImageUrl = "/images/cuzdan.jpg", ProductName = "Cüzdan 1", ProductSummary = "Cüzdan 1", Showcase = true, ProductPrice = 37 },
                new Product() { ProductId = 5, CategoryId = 2, ProductImageUrl = "/images/cuzdan.jpg", ProductName = "Cüzdan 2", ProductSummary = "Cüzdan 2", Showcase = false, ProductPrice = 3_865 },
                new Product() { ProductId = 6, CategoryId = 2, ProductImageUrl = "/images/cuzdan.jpg", ProductName = "Cüzdan 3", ProductSummary = "Cüzdan 3", Showcase = false, ProductPrice = 805 },
                new Product() { ProductId = 7, CategoryId = 3, ProductImageUrl = "/images/baykusanahtar.jpg", ProductName = "Pembe baykuş anahtarlık", ProductSummary = "Pembe baykuş anahtarlık", Showcase = true, ProductPrice = 120 },
                new Product() { ProductId = 8, CategoryId = 3, ProductImageUrl = "/images/baykusanahtar.jpg", ProductName = "Sarı baykuş anahtarlık", ProductSummary = "Sarı baykuş anahtarlık", Showcase = false, ProductPrice = 11_280 },
                new Product() { ProductId = 9, CategoryId = 3, ProductImageUrl = "/images/baykusanahtar.jpg", ProductName = "Yeşil baykuş anahtarlık", ProductSummary = "Yeşil baykuş anahtarlık", Showcase = false, ProductPrice = 85 },
                new Product() { ProductId = 10, CategoryId = 4, ProductImageUrl = "/images/kahvecanta.jpg", ProductName = "Kahverengi çiçek çanta", ProductSummary = "Kahverengi çiçek çanta", Showcase = true, ProductPrice = 420 },
                new Product() { ProductId = 11, CategoryId = 4, ProductImageUrl = "/images/pembecanta.jpg", ProductName = "Pembe çiçek çanta", ProductSummary = "Pembe çiçek çanta", Showcase = false, ProductPrice = 120 },
                new Product() { ProductId = 12, CategoryId = 4, ProductImageUrl = "/images/kahvecanta.jpg", ProductName = "Mor çiçek çanta", ProductSummary = "Mor çiçek çanta", Showcase = false, ProductPrice = 375 },
                new Product() { ProductId = 13, CategoryId = 5, ProductImageUrl = "/images/martenicka.jpg", ProductName = "Marteniçka dilek bilekliği", ProductSummary = "Marteniçka dilek bilekliği", Showcase = true, ProductPrice = 12 },
                new Product() { ProductId = 14, CategoryId = 6, ProductImageUrl = "/images/kuzucuk.jpg", ProductName = "Kuzucuk", ProductSummary = "Kuzucuk", Showcase = true, ProductPrice = 12 }
            );
        }
    }
}