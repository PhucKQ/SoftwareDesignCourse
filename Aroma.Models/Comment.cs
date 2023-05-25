using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        public int? BlogId { get; set; }
        [ForeignKey("BlogId")]
        public Blog? Blog { get; set; }

        public int? ParentCommentId { get; set; }
        [ForeignKey("ParentCommentId")]
        public Comment? ParentComment { get; set; }
    }
}
