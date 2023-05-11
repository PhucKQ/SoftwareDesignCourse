using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma.Models
{
    public class ProductSpecification
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }

        public string SpecificationId { get; set; }
        [ForeignKey("SpecificationId")]
        [ValidateNever]
        public Specification Specification { get; set; }
    }
}
