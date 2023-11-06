using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName).IsRequired();

            builder.HasData(
                new Category() { CategoryId = 1, CategoryName = "Toka" },
                new Category() { CategoryId = 2, CategoryName = "Cüzdan" },
                new Category() { CategoryId = 3, CategoryName = "Anahtarlık" },
                new Category() { CategoryId = 4, CategoryName = "Çanta" },
                new Category() { CategoryId = 5, CategoryName = "Marteniçka" },
                new Category() { CategoryId = 6, CategoryName = "Oyuncak" }
            );
        }
    }
}