using System.ComponentModel.DataAnnotations;


namespace Entities.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

        [Required(ErrorMessage = "İsim alanı zorunludur.")]
        public String? Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı zorunludur.")]
        public String? Surname { get; set; }

        public String FullName => $"{Name} {Surname.ToUpper()}";

        [Required(ErrorMessage = "Mahalle alanı zorunludur.")]
        public String? District { get; set; }

        [Required(ErrorMessage = "Sokak alanı zorunludur.")]
        public String? Street { get; set; }

        public String? Avenue { get; set; }

        [Required(ErrorMessage = "Şehir alanı zorunludur.")]
        public String? City { get; set; }

        public bool Shipped { get; set; }
        public DateTime OrderedAt { get; set; } = DateTime.Now;
    }
}