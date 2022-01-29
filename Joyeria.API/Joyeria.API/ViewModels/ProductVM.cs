﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Joyeria.API.ViewModels
{
    public class ProductVM
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
