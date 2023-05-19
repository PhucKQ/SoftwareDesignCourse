using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AromaShop.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public string? ImagePath { get; set; }

        [NotMapped]
        public int Count { get; set; }
    }
}