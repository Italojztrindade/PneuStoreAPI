﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Model
{
 
    public class Product
 
    {
        [ScaffoldColumn(false)]
 
        public int ProductID { get; set; }
 

        [Required, StringLength(100), Display(Name = "Name")]
 
        public string ProductName { get; set; }
 

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
 
        public string Description { get; set; }
 

 
        public string ImagePath { get; set; }
 

        [Display(Name = "Price")]
 
        public double? UnitPrice { get; set; }
 

 
        public DateTime? created { get; set; }
 
 
        public DateTime? updated { get; set; }
 
 
        public string updatedById { get; set; }
 
 
        public IdentityUser updatedBy { get; set; }
 
 
        public string createdById { get; set; }
 
 
        public IdentityUser createdBy { get; set; }
 
 
        public int? CategoryID { get; set; }
 

 
        public virtual Category Category { get; set; }
 
    }
}
