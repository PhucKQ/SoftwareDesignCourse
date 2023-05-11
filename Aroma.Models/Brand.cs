using System.ComponentModel.DataAnnotations;

namespace Aroma.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Summary { get; set; }
        public string? ImagePath { get; set; }
    }
}