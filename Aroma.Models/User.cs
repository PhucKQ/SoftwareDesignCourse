using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    public class User : IdentityUser
    {
        public User() 
        {
            Id = new Guid().ToString();
        }

        public string? Fullname { get; set; }
        public string? AvatarPath { get; set; }
        public bool IsAdmin { get; set; }

        [ValidateNever]
        public string? Role { get; set; }
    }
}
