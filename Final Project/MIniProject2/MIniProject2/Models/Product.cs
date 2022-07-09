using System.ComponentModel.DataAnnotations;

namespace MiniProject2.Models
{
    public class Product
    {
        [key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string brand {get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }


    }
}
