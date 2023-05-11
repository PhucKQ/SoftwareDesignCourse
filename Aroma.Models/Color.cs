using System.ComponentModel.DataAnnotations;

namespace Aroma.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Code { get; set; }
        public string? ImagePath { get; set; }
    }
}