using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<Brand>? Brands { get; set;}

        public IEnumerable<Color>? Colors { get; set; }

        public IEnumerable<Category>? Categories { get; set; }

    }
}
