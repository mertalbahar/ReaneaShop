using System.ComponentModel.DataAnnotations;


namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public String? ProductName { get; init; } = String.Empty;
        public String? ProductSummary { get; init; } = String.Empty;

        [Required(ErrorMessage = "Birim fiyat zorunludur.")]
        public decimal ProductPrice { get; init; }
        public int? CategoryId { get; init; }
    }
}