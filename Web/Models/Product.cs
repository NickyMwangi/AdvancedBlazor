using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }   = string.Empty;
        [Required]
        public string Description { get; set; }  = string.Empty ;
        [Required]
        [Range(1,10000000)]
        public double Price { get; set; }     
        public bool IsActive { get; set; }
        [Required]
        public DateTime IsAvailableFrom { get; set; }= DateTime.Now;
        [Required]
        public Categories Category { get; set; }
        public List<ProductProps> ProdProps { get; set; }
    }

    public class ProductProps
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; }  = string.Empty;

    }

    public enum Categories
    {
        Fruits,
        Desserts,
        Appetizer,
        Electronics
    }
}
