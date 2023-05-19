using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Brand>? Brands { get; set;}

        public IEnumerable<Color>? Colors { get; set; }

        public IEnumerable<Category>? Categories { get; set; }
        public PaginatedList<Product>? PaginatedProducts { get; set; }
        public List<Product>? TopProducts { get; set; }
    }
}
