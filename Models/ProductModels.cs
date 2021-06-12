﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webtt.Models
{
    public class ProductModels
    {
        public int ProductId { get; set; }
        [DisplayName("ProductName")]
        [Required(ErrorMessage = "Not null")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string ProductName { get; set; }
        [DisplayName("Image")]
        public string ProductImage { get; set; } 
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Price")]
        [Required]
        [Range(0,999999.99999)]
        public double ProductPrice { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        private static int nextId = 1;
        public ProductModels()
        {
            ProductId = nextId;
            nextId++;
        }
        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
