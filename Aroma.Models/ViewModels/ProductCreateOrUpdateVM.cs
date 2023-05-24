using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models.ViewModels
{
    public class ProductCreateOrUpdateVM
    {
        public ProductCreateOrUpdateVM()
        {
            Product = new Product();
            SpecDetails = new List<SpecDetails>();
        }
        public Product Product { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? CategorySelectList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? BrandSelectList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? ColorSelectList { get; set; }
        
        [ValidateNever]
        public int ColorIds { get; set; }

        [ValidateNever]
        public List<SpecDetails> SpecDetails { get; set; }
    }
}
