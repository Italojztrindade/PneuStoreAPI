﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Model
{
   
 
        public class CartItem
 
        {
            [Key]
 
            public int ItemId { get; set; }
 

 
            public string CartId { get; set; }
 

 
            public int Quantity { get; set; }
 

 
            public System.DateTime DateCreated { get; set; }
 

 
            public int ProductId { get; set; }
 

 
            public virtual Product Product { get; set; }
 

        }

    
}
