using System.ComponentModel.DataAnnotations;


namespace Entities.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String? ProductName { get; set; } = String.Empty;
        public String? ProductSummary { get; set; } = String.Empty;
        public decimal ProductPrice { get; set; }
        public String? ProductImageUrl { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}