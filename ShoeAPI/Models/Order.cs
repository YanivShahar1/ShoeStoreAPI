using ShoeAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoeAPI.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Order() { }
    }
}


