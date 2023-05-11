﻿using System.ComponentModel.DataAnnotations;

namespace Aroma.Models
{
    public class Specification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Summary { get; set; }
    }
}