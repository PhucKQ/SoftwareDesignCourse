using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models.ViewModels
{
    public class UserCreateOrUpdateVM
    {
        public required User User { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? Roles { get; set; }
    }
}
