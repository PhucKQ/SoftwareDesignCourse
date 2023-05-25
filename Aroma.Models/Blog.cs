using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Summary { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string? Content { get; set; }
        public int View { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Comment>? Comments { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

    }
}
