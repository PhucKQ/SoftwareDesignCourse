using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    public class ProductSpecification
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int SpecificationId { get; set; }

        [ForeignKey("SpecificationId")]
        public Specification Specification { get; set; }
    }
}
