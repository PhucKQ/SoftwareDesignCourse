using System.ComponentModel.DataAnnotations;

namespace AromaShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public string? ImagePath { get; set; }
    }
}