namespace ReaneaShopApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String? ProductName { get; set; } = String.Empty;
        public String? ProductSummary { get; set; } = String.Empty;
        public decimal ProductPrice { get; set; }
    }
}