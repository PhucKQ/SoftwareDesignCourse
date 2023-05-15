using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AromaShop.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? ImagePath { get; set; }

        public List<ProductColor>? ProductColor { get; set; }
    }
}