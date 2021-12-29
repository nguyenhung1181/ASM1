﻿using System.ComponentModel.DataAnnotations;

namespace ASM1.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? Name { get; set; }
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [Required]
        [StringLength(30)]
        public string? Unit { get; set; }
    }
}
