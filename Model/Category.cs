﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Model
{
 
    public class Category
 
    {
        [ScaffoldColumn(false)]
 
        public int CategoryID { get; set; }
 

        [Required, StringLength(100), Display(Name = "Name")]
 
        public string CategoryName { get; set; }
 

        [Display(Name = "Product Description")]
 
        public string Description { get; set; }
 

 
        public virtual ICollection<Product> Products { get; set; }
 
    }
}
