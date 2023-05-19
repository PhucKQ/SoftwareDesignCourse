using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AromaShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Summary { get; set; }
        [Display(Name = "Image Path")]
        public string? ImagePath { get; set; }

        [NotMapped]
        public int Count { get; set; }
    }
}