using System.ComponentModel.DataAnnotations;


namespace Entities.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public String? ProductName { get; set; } = String.Empty;
        public String? ProductSummary { get; set; } = String.Empty;

        [Required(ErrorMessage = "Birim fiyat zorunludur.")]
        public decimal ProductPrice { get; set; }
    }
}