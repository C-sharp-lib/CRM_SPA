using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [Precision(10,2)]
        public decimal UnitPrice { get; set; }
        [Precision(10,2)]
        public decimal TotalPrice { get; set; }
    }
}
