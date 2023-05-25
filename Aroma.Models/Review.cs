using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string? Message { get; set; }
        public decimal Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public User? User { get; set; }
    }
}
