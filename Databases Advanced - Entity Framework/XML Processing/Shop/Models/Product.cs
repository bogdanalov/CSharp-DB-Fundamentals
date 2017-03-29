﻿namespace Shop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Serializable()]
    public class Product
    {
        public Product()
        {
            this.Categories = new HashSet<Category>();
        }
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("Buyer")]
        public int? BuyerId { get; set; }

        
        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public virtual User Buyer { get; set; }

        [Required]
        public virtual User Seller { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
