using System.ComponentModel;

namespace Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }   = string.Empty;
        public string Description { get; set; }  = string.Empty ;
        public double Price { get; set; }     
        public bool IsActive { get; set; }
        public List<ProductProps> ProdProps { get; set; }
    }

    public class ProductProps
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; }  = string.Empty;

    }
}
