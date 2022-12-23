﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SportShop.Models
{
    public class Product
    {
        public long? Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public string Description { get; set; }=String.Empty;
        [Column(TypeName ="decimal(8,2)")]
        public decimal Price { get; set; }
        public string Category { get; set; }=String.Empty;  
    }
}
