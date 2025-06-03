using System.ComponentModel.DataAnnotations;

namespace ShoeAPI.Models
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Size { get; set; }
        public string Color { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
