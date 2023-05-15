using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public double Price { get; set; }
        public string? ImagePath { get; set; }
        public string? ThumbnailPath { get; set; }
        public bool Availability { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }

        public List<ProductColor>? ProductColor { get; set; }

        public List<ProductSpecification>? ProductSpecification { get; set; }
    }
}
