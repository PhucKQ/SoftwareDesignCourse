using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }
        public string? ImagePath { get; set; }
        public string? ThumbnailPath { get; set; }
        public bool Availability { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int ColorId { get; set; }
        [ForeignKey("ColorIdId")]
        public Color Color { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
    }
}
